Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports System.Net.Mail
Imports System.Net

Public Class Correos

#Region "Envio de Correos"

    Public Shared Function SendMail(ByVal data As MailOptionsInfo) As LogProcess
        Dim Log As New LogProcess
        Dim IntPosCreate As Integer = 0
        Dim IntPosError As Integer = 0
        Dim osmtp As New SmtpClient()

        If data.SmtpServerConfig Is Nothing Then
            data.SmtpServerConfig = ExpertisApp.ExecuteTask(Of Business.General.Correos.DataCorreos, SmtpServerInfo)(AddressOf Solmicro.Expertis.Business.General.Correos.LoadSmtpServerInfo, Nothing)
        End If

        Dim ServerMail As New Mail.SmtpClient
        ServerMail.Host = data.SmtpServerConfig.SmtpServerName
        ServerMail.Port = data.SmtpServerConfig.SmtpServerPort
        ServerMail.EnableSsl = data.SmtpServerConfig.UseSSL

        Dim CredUser As New NetworkCredential
        CredUser.UserName = data.SmtpServerConfig.UserName
        CredUser.Password = data.SmtpServerConfig.UserPassword

        ServerMail.Credentials = CredUser

        For Each MailUser As EmailInfo In data.Mails
            Dim NewMail As Net.Mail.MailMessage
            Try
                Dim StrMailsTo() As String = Strings.Split(MailUser.Email, ";")
                If StrMailsTo.Length > 0 Then
                    Dim IntPos As Integer = 0
                    NewMail = New Net.Mail.MailMessage(data.SmtpServerConfig.UserMail, StrMailsTo(IntPos).Trim)
                    IntPos += 1
                    For i As Integer = IntPos To StrMailsTo.Length - 1
                        If Not String.IsNullOrEmpty(StrMailsTo(i)) Then NewMail.To.Add(StrMailsTo(i).Trim)
                    Next
                Else : NewMail = New Net.Mail.MailMessage(data.SmtpServerConfig.UserMail, MailUser.Email)
                End If
                If Length(MailUser.EMailsCC) > 0 Then
                    Dim StrMailsCC() As String = Strings.Split(MailUser.EMailsCC, ";")
                    If StrMailsCC.Length > 0 Then
                        For i As Integer = 0 To StrMailsCC.Length - 1
                            If Not String.IsNullOrEmpty(StrMailsCC(i)) Then NewMail.CC.Add(StrMailsCC(i).Trim)
                        Next
                    End If
                End If
                If Length(MailUser.EMailsCCO) > 0 Then
                    Dim StrMailsCCO() As String = Strings.Split(MailUser.EMailsCCO, ";")
                    If StrMailsCCO.Length > 0 Then
                        For i As Integer = 0 To StrMailsCCO.Length - 1
                            If Not String.IsNullOrEmpty(StrMailsCCO(i)) Then NewMail.Bcc.Add(StrMailsCCO(i).Trim)
                        Next
                    End If
                End If

                If Length(MailUser.FicheroMensaje) > 0 Then
                    Correos.TratarBodyMailHtml(NewMail, MailUser)
                Else : NewMail.Body = MailUser.Mensaje
                End If
                NewMail.Subject = MailUser.Asunto
                If Length(MailUser.FicheroAdjunto) > 0 Then
                    Dim StrAttachs() As String = Strings.Split(MailUser.FicheroAdjunto, ";")
                    If StrAttachs.Length > 0 Then
                        For i As Integer = 0 To StrAttachs.Length - 1
                            NewMail.Attachments.Add(New Net.Mail.Attachment(StrAttachs(i).Trim))
                        Next
                    Else : NewMail.Attachments.Add(New Net.Mail.Attachment(MailUser.FicheroAdjunto))
                    End If
                End If
                Try
                    NewMail.BodyEncoding = System.Text.Encoding.Default


                    If ServerMail.EnableSsl = True Then
                        oSMTP.EnableSsl = True
                        'Bypass de validación de certificado (para problemas con servidores de SMTP con SSL con certificados que no validan en nuestra máquina)
                        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
                    End If
                    NewMail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    ServerMail.Send(NewMail)

                    ReDim Preserve Log.CreatedElements(IntPosCreate)
                    Log.CreatedElements(IntPosCreate) = New CreateElement
                    Log.CreatedElements(IntPosCreate).NElement = MailUser.Email
                    Log.CreatedElements(IntPosCreate).ExtraInfo = MailUser.FicheroAdjunto
                    IntPosCreate += 1
                Catch ex As System.Net.Mail.SmtpException
                    ReDim Preserve Log.Errors(IntPosError)
                    Log.Errors(IntPosError) = New ClassErrors
                    Log.Errors(IntPosError).Elements = MailUser.Email
                    If Not ex.InnerException Is Nothing Then
                        Log.Errors(IntPosError).MessageError = ex.InnerException.Message
                    Else : Log.Errors(IntPosError).MessageError = ex.Message
                    End If
                    IntPosError += 1
                End Try
            Catch ex As Exception
                ReDim Preserve Log.Errors(IntPosError)
                Log.Errors(IntPosError) = New ClassErrors
                Log.Errors(IntPosError).Elements = MailUser.Email
                If Not ex.InnerException Is Nothing Then
                    Log.Errors(IntPosError).MessageError = ex.InnerException.Message
                Else : Log.Errors(IntPosError).MessageError = ex.Message
                End If
                IntPosError += 1
            End Try
            If Not NewMail Is Nothing Then NewMail.Dispose()
        Next
        Return Log
    End Function

    Private Shared Function ValidarCertificado(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        'bypass de la validación del certificado (aplicar aquí validación personalizada si fuera el caso)
        Return True
    End Function


    Public Shared Sub TratarBodyMailHtml(ByRef NewMail As Net.Mail.MailMessage, ByVal MailInfo As EmailInfo)
        NewMail.IsBodyHtml = True
        Dim fichero As New System.IO.StreamReader(MailInfo.FicheroMensaje, System.Text.Encoding.Default, True)
        Dim Line As String
        Dim StrMensaje As String = String.Empty
        Do
            Line = fichero.ReadLine()
            If Not Line Is Nothing Then Correos.TratarCaracteresLinea(Line)
            StrMensaje = StrMensaje & Line & vbNewLine
        Loop Until Line Is Nothing
        fichero.Close()
        NewMail.Body = StrMensaje
    End Sub

    Public Shared Sub TratarCaracteresLinea(ByRef StrLinea As String)
        If StrLinea.Contains("Á") Then StrLinea = StrLinea.Replace("Á", "&Aacute;")
        If StrLinea.Contains("á") Then StrLinea = StrLinea.Replace("á", "&aacute;")
        If StrLinea.Contains("É") Then StrLinea = StrLinea.Replace("É", "&Eacute;")
        If StrLinea.Contains("é") Then StrLinea = StrLinea.Replace("é", "&eacute;")
        If StrLinea.Contains("Í") Then StrLinea = StrLinea.Replace("Í", "&Iacute;")
        If StrLinea.Contains("í") Then StrLinea = StrLinea.Replace("í", "&iacute;")
        If StrLinea.Contains("Ó") Then StrLinea = StrLinea.Replace("Ó", "&Oacute;")
        If StrLinea.Contains("ó") Then StrLinea = StrLinea.Replace("ó", "&oacute;")
        If StrLinea.Contains("Ñ") Then StrLinea = StrLinea.Replace("Ñ", "&Ntilde;")
        If StrLinea.Contains("ñ") Then StrLinea = StrLinea.Replace("ñ", "&ntilde;")
        If StrLinea.Contains("Ú") Then StrLinea = StrLinea.Replace("Ú", "&Uacute;")
        If StrLinea.Contains("ú") Then StrLinea = StrLinea.Replace("ú", "&uacute;")
        If StrLinea.Contains("Ü") Then StrLinea = StrLinea.Replace("Ü", "&Uuml;")
        If StrLinea.Contains("ü") Then StrLinea = StrLinea.Replace("ü", "&uuml;")
        If StrLinea.Contains("¡") Then StrLinea = StrLinea.Replace("¡", "&iexcl;")
        If StrLinea.Contains("ª") Then StrLinea = StrLinea.Replace("ª", "&ordf;")
        If StrLinea.Contains("¿") Then StrLinea = StrLinea.Replace("¿", "&iquest;")
        If StrLinea.Contains("º") Then StrLinea = StrLinea.Replace("º", "&ordm;")
    End Sub

    Public Shared Function EnviarMailTest(ByVal data As SmtpServerInfo) As LogProcess
        Dim MailTest As New MailOptionsInfo
        MailTest.SmtpServerConfig = data
        ReDim MailTest.Mails(0)
        MailTest.Mails(0) = New EmailInfo
        MailTest.Mails(0).Asunto = "CORREO GENERADO POR EXPERTIS - ARTICULOS CON STOCK POR DEBAJO DEL MINIMO"
        MailTest.Mails(0).Mensaje = data.Cuerpo
        MailTest.Mails(0).EMailsCC = "aaron.gutierrez@tecozam.com;jaime.moran@tecozam.com;jose.giron@tecozam.com"
        MailTest.Mails(0).Email = data.UserMail
        Return SendMail(MailTest)
    End Function

#End Region

#Region "Tratamiento de Log de Mails"

    Public Shared Sub TratarMailLog(ByVal LogPrc As LogProcess)
        Dim DtLog As DataTable = CrearLogDataSource()
        'Mensaje de Exito
        For Each Elm As CreateElement In LogPrc.CreatedElements
            Dim DrNew As DataRow = DtLog.NewRow
            DrNew("ElementsCreated") = "Correo enviado a: " & Elm.NElement
            DtLog.Rows.Add(DrNew)
        Next
        'Mensajes de Error
        For Each Err As ClassErrors In LogPrc.Errors
            Dim DrNewEr As DataRow = DtLog.NewRow
            DrNewEr("ElementsCreated") = "Fallo en fichero: " & Err.Elements
            DrNewEr("LocationError") = Err.Elements
            DrNewEr("Message") = Err.MessageError
            DtLog.Rows.Add(DrNewEr)
        Next
        Dim FrmLog As New LogProcesos
        FrmLog.DataSource = DtLog
        FrmLog.ShowDialog()
    End Sub

#End Region

End Class