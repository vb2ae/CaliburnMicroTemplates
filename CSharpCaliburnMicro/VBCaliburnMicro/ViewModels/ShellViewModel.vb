Imports Caliburn.Micro

Public Class ShellViewModel
    Inherits Conductor(Of IScreen).Collection.OneActive
    public Property ActiveItem as IScreen

    Public sub New()
        ActiveItem=New HomeViewModel()
    End sub

End Class
