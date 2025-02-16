'Malachi Marlow
'Spring 2025
'RCET2265
'Accumulate Messages
'https://github.com/MalachiMarlow/AccumulateMessages.git


Imports System
Imports System.Diagnostics.CodeAnalysis

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static message As New Text.StringBuilder
        'StringBuilder will act like an array builder, basically placing in text that is needed to ensure the function will work.
        If clear Then
            message.Clear()
            ' Will clear the functions message
        ElseIf newMessage = "" Then
            message.Append(newMessage)
            'When blank, the newMessage will display a blank
        ElseIf newMessage <> "" Then
            message.AppendLine(newMessage)
            'When the newMessage is not blank, it will paste whatever stringBuilder has stored. 
        End If

        Return message.ToString
        'messages
    End Function


End Module
