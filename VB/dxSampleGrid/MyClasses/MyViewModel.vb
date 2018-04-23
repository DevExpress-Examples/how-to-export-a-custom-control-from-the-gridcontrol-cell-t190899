Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Input

Namespace dxSampleGrid
	Public Class MyViewModel

		Public Sub New()
			CreateList()
			ViewModelName = "MyViewModel1"
			SomeValue = 5
		End Sub
		Private _viewModelName As String
		Private _selectedPerson As Person
		Private _myVoidCommand As ICommand


		Private privateListPerson As ObservableCollection(Of Person)
		Public Property ListPerson() As ObservableCollection(Of Person)
			Get
				Return privateListPerson
			End Get
			Set(ByVal value As ObservableCollection(Of Person))
				privateListPerson = value
			End Set
		End Property
		Public Property ViewModelName() As String
			Get
				Return _viewModelName
			End Get
			Set(ByVal value As String)
				_viewModelName = value

			End Set
		End Property
		Private privateSomeValue As Integer
		Public Property SomeValue() As Integer
			Get
				Return privateSomeValue
			End Get
			Set(ByVal value As Integer)
				privateSomeValue = value
			End Set
		End Property
		Public Property SelectedPerson() As Person
			Get
				Return _selectedPerson
			End Get
			Set(ByVal value As Person)
				_selectedPerson = value

			End Set
		End Property
		Private privateListSomeClass As ObservableCollection(Of SomeClass)
		Public Property ListSomeClass() As ObservableCollection(Of SomeClass)
			Get
				Return privateListSomeClass
			End Get
			Set(ByVal value As ObservableCollection(Of SomeClass))
				privateListSomeClass = value
			End Set
		End Property

		Public ReadOnly Property MyVoidCommand() As ICommand
			Get
				'if (_myVoidCommand == null)
				'    _myVoidCommand = new DelegateCommand(SomeMethod);
				Return _myVoidCommand
			End Get
		End Property


		Private Sub CreateList()
			ListPerson = New ObservableCollection(Of Person)()
			For i As Integer = 0 To 9
				Dim p As New Person(i)
				ListPerson.Add(p)
			Next i
			SelectedPerson = ListPerson(3)
			ListSomeClass = New ObservableCollection(Of SomeClass)()
			For i As Integer = 0 To 199 Step 10
				ListSomeClass.Add(New SomeClass(i))
			Next i
		End Sub
		Private Sub SomeMethod()
			Debug.Print("Some action")

		End Sub

		


	End Class
End Namespace
