' Written by Valery Samovich 
' July 19, 2015
Option Strict On
Option Explicit On

Public Class Form1

    ' Class-level constants for total possible points per category
    Const intTEST As Integer = 50       ' Possible points per one test
    Const intTUTORIAL As Integer = 25   ' Possible points per one tutorial
    Const intPROJECT As Integer = 40    ' Possible points per one project

    ' Array declarations for three categories of scores.
    Dim intTests(7) As Integer       ' Hold the 8 tests scores
    Dim intTutorials(6) As Integer   ' Hold the 7 tutorials scores
    Dim intProjects(6) As Integer    ' Hold the 7 projects scores

End Class
