'Import the Regex Class
Imports System.Text.RegularExpressions

Public Class VB_Ch9_Sup

    'Private variable available to our Class the we will use to stor the contents of the file.
    'We store the contents of the File here so we only have to read in the file one time.
    Private strWorkingString As String

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        'Here we would put the code that will allow the user to navigate to a file on the local
        'computer.
        Using ofd As New OpenFileDialog
            'Here we filter the results to include only text files.
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            'Here we check to see if the user has selected a file.
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                'When the file is selected, we put the path in the text box we created for it
                'You could also create a string variable and store it if you have need.
                txtFilePath.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        'Here we check to see that the user has selected a file.
        If (txtFilePath.Text) = "" Then
            MsgBox("You must select a text file!")
        Else
            'Read the contents of the file into our Class String variable
            strWorkingString = IO.File.ReadAllText(txtFilePath.Text)
            'Here we load the contents of the file into the text box on the View tab.
            txtDisplayText.Text = strWorkingString
            'Here we switch the user to the View tab to show them the results.
            TabControl1.SelectTab(1)
        End If
    End Sub

    Private Sub btnRemPunct_Click(sender As Object, e As EventArgs) Handles btnRemPunct.Click
        'String to hold our modification remove punctuation
        Dim strNoPunctuation As String
        'Remove the punctuation
        strNoPunctuation = Regex.Replace(strWorkingString, "[^A-Za-z0-9 \r\n]+", String.Empty)
        'Write the modified text to the text box
        txtDisplayText.Text = strNoPunctuation
    End Sub

    Private Sub btnMakeLower_Click(sender As Object, e As EventArgs) Handles btnMakeLower.Click
        'String to hold our modification to lower
        Dim strLowerCase As String
        'Convert the string to lower case
        strLowerCase = txtDisplayText.Text.ToLower
        'Write the modified text to the text box
        txtDisplayText.Text = strLowerCase
    End Sub

    Private Sub btnCountToFile_Click(sender As Object, e As EventArgs) Handles btnCountToFile.Click
        'Create a text file that will show the words in the original file and the number
        'of times it appears in the text.
        Dim WordCountWriter As IO.StreamWriter
        WordCountWriter = My.Computer.FileSystem.OpenTextFileWriter("WordCount.txt", False)

        'Create a counter we will use to count each word and set it to 0.
        Dim intWordCount As Integer = 0

        'Create a counter we will use to keep track of the total words.
        Dim intTotalWordCount As Integer = 0

        'Create a dictionary to hold the words and their count
        Dim Words As New Dictionary(Of String, Integer)

        'Create an integer variable that can be used in the dictionary to hold the count
        Dim intKeyValue As Integer

        'Create a string repersenation of the dictionary variables.
        Dim strKey As String
        Dim strValue As String

        'Create an Array of the text using Regex
        Dim strCountWords() As String = Regex.Split(strWorkingString, "\W+")
        'Create a variable we will use to loop.
        Dim strSingleWord As String

        'For each word in the text we check to see if it has been added to the dictionary.
        For Each strSingleWord In strCountWords
            'If the word is in the dictionary increment the count
            If (Words.ContainsKey(strSingleWord)) Then
                intKeyValue = Words(strSingleWord)
                intKeyValue += 1
                Words(strSingleWord) = intKeyValue
                'If it is not in the dictionary add it to the dictionary
            Else Words.Add(strSingleWord, 1)
                intWordCount += 1
            End If
        Next

        'Here we write each word and its count into the text file.
        Dim WordPair As KeyValuePair(Of String, Integer)
        For Each WordPair In Words
            strKey = Convert.ToString(WordPair.Key)
            strValue = Convert.ToString(WordPair.Value)
            intTotalWordCount = intTotalWordCount + WordPair.Value
            WordCountWriter.WriteLine(strKey + "," + strValue)
        Next

        'Write the total words to the file.
        WordCountWriter.WriteLine("Total Word Count is " & intTotalWordCount)
        'Close the file
        WordCountWriter.Close()
        'Notify the user the file has been written.
        MessageBox.Show("File Write Complete.", "WriteFile",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
