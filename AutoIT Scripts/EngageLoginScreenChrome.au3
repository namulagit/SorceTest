

#region --- Internal functions Au3Recorder Start ---


WinWaitActive("", "Chrome Legacy Window", "120")
If WinExists("", "Chrome Legacy Window") Then
Send($user)
Send("{TAB}")
Send($pass)
Send("{ENTER}")
EndIf
#endregion --- Au3Recorder generated code End ---
