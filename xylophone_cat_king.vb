Imports System

Public Enum CreativeEconomy
    DigitalDesign = 0
    Ecommerce = 1
    Music = 2
    Film = 3
    Television = 4
    Games = 5
    Fashion = 6
    Art = 7
    Publishing = 8
    Photography = 9
End Enum

Public Class CreativeEconomyClass
    Public Sub New()
    End Sub

    Public Function GetCreativeEconomyDescription(ByVal ce As CreativeEconomy) As String
        Select Case ce
            Case CreativeEconomy.DigitalDesign
                Return "Digital design is the process of creating graphics, animation and other interactive designs for use in websites, apps and more."
            Case CreativeEconomy.Ecommerce
                Return "Ecommerce is the buying and selling of goods and services, or the transmitting of funds or data, over an electronic network."
            Case CreativeEconomy.Music
                Return "The music business is a complex industry that's rapidly changing due to new technologies and the evolving tastes of consumers."
            Case CreativeEconomy.Film
                Return "Film is a powerful medium that captivates, educates and entertains. Film production involves many different creative disciplines, from writing and directing to cinematography and editing."
            Case CreativeEconomy.Television
                Return "Television is a medium for broadcasting and receiving visual images and sounds from around the world. It is a powerful form of communication, entertainment and education."
            Case CreativeEconomy.Games
                Return "Video games are interactive electronic games that are designed to be enjoyed by players of all ages and backgrounds. They can be played alone, or with friends and family."
            Case CreativeEconomy.Fashion
                Return "Fashion design is the art of creating clothing and accessories with aesthetic value. It combines art and commerce, and reflects the current lifestyle and trends of its time."
            Case CreativeEconomy.Art
                Return "Art is a broad term that encompasses a variety of media, ranging from sculpture and painting to photography and digital media. Art is a way of expressing ideas, feelings and visualizing the world."
            Case CreativeEconomy.Publishing
                Return "Publishing is the process of making information available in printed or digital form. It includes editorial, marketing, and distribution activities, as well as the development of new technologies."
            Case CreativeEconomy.Photography
                Return "Photography is a form of visual art that can be used to tell stories, capture moments and evoke emotions. It is a powerful tool for expressing ideas, and can be used to create beautiful images of our world."
        End Select
    End Function
End Class

Public Module CreativeEconomyModule
    Public Sub Main()
        Dim creativeEconomy As New CreativeEconomyClass()

        Console.WriteLine("Digital Design: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.DigitalDesign))
        Console.WriteLine("Ecommerce: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Ecommerce))
        Console.WriteLine("Music: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Music))
        Console.WriteLine("Film: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Film))
        Console.WriteLine("Television: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Television))
        Console.WriteLine("Games: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Games))
        Console.WriteLine("Fashion: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Fashion))
        Console.WriteLine("Art: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Art))
        Console.WriteLine("Publishing: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Publishing))
        Console.WriteLine("Photography: " & creativeEconomy.GetCreativeEconomyDescription(CreativeEconomy.Photography))
    End Sub
End Module