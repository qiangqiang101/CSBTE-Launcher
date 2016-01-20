﻿Option Strict Off
Option Explicit On
Module INIread

    Public Function ReadIniValue(ByRef INIpath As String, ByRef KEY As String, ByRef Variable As String) As String
        Dim NF As Short
        Dim Temp As String
        Dim LcaseTemp As String
        Dim ReadyToRead As Boolean

AssignVariables:
        NF = FreeFile
        ReadIniValue = ""
        KEY = "[" & LCase(KEY) & "]"
        Variable = LCase(Variable)

EnsureFileExists:
        FileOpen(NF, INIpath, OpenMode.Binary)
        FileClose(NF)
        SetAttr(INIpath, FileAttribute.Archive)

LoadFile:
        FileOpen(NF, INIpath, OpenMode.Input)
        While Not EOF(NF)
            Temp = LineInput(NF)
            LcaseTemp = LCase(Temp)
            If InStr(LcaseTemp, "[") <> 0 Then ReadyToRead = False
            If LcaseTemp = KEY Then ReadyToRead = True
            If InStr(LcaseTemp, "[") = 0 And ReadyToRead = True Then
                If InStr(LcaseTemp, Variable & "=") = 1 Then
                    ReadIniValue = Mid(Temp, 1 + Len(Variable & "="))
                    FileClose(NF) : Exit Function
                End If
            End If
        End While
        FileClose(NF)
    End Function
End Module