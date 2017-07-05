Module modEnterGrades

    Sub Main()
        Dim grade As Integer = 0 ' one grade
        Dim aCount As Integer = 0 ' number of A's
        Dim bCount As Integer = 0 ' number of B's
        Dim cCount As Integer = 0 ' number of C's
        Dim dCount As Integer = 0 ' number of D's
        Dim fCount As Integer = 0 ' number of F's

        Console.WriteLine("Enter a grade, -1 to quit: ")
        grade = Console.ReadLine()


        'input and process grades
        While grade <> -1

            Select Case grade 'determine which grade was input

                Case 100    ' student scored a 100
                    Console.WriteLine("Perfect Score!" & vbCrLf &
                                      "Letter grade: A" & vbCrLf)
                    aCount += 1

                Case 90 To 99 ' student scored 90-99
                    Console.WriteLine("Letter grade: A" & vbCrLf)
                    aCount += 1

                Case 80 To 89 ' student scored 80-89
                    Console.WriteLine("Letter grade: B" & vbCrLf)
                    bCount += 1

                Case 70 To 79 ' student scored 70-79
                    Console.WriteLine("Letter grade: C" & vbCrLf)
                    cCount += 1

                Case 60 To 69 ' student scored 60-69
                    Console.WriteLine("Letter grade: D" & vbCrLf)
                    dCount += 1

                Case 0, 10 To 59 ' student scored 0 or 10-59 (10 points for attendance)
                    Console.WriteLine("Letter grade: F" & vbCrLf)
                    fCount += 1

                Case Else 'alert the user that an invalide grade was entered
                    Console.WriteLine("Invalid input." & "Please enter a valid grade" & vbCrLf)

            End Select

            Console.WriteLine("Enter a grade, -1 to quit: ")
            grade = Console.ReadLine()
        End While

        ' display count of each letter grade
        Console.WriteLine(vbCrLf &
                          "Totals for each letter grade are: " & vbCrLf &
                          "A: " & aCount & vbCrLf & "B: " & cCount & vbCrLf &
                          "C: " & cCount & vbCrLf & "D: " & dCount & vbCrLf &
                          "F: " & fCount & vbCrLf)
    End Sub ' Main

End Module ' modEnterGrades
