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

Namespace dxSampleGrid
	  <DebuggerDisplay("Id = {Id}, Name = {FirstName}, Value = {Age}")> _
	  Public Class Person

		Public Sub New()

		End Sub
		Public Sub New(ByVal i As Integer)
			FirstName = "FirstName" & i
			LastName = "LastName" & i
			Age = i * 10
			Group = i Mod 2 = 0
			Id = i
			SomeClasses = New ObservableCollection(Of SomeClass)()
			For j As Integer = 0 To 4
				SomeClasses.Add(New SomeClass(j))
			Next j
			BirthDate = New DateTime(2010, 1, 1).AddDays(i)
		End Sub

		Private _firstName As String

		Public Property FirstName() As String
			Get
				Return _firstName
			End Get
			Set(ByVal value As String)
				_firstName = value

			End Set
		End Property
		Private privateLastName As String
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
		Private _age As Integer

		Public Property Age() As Integer
			Get
				Return _age
			End Get
			Set(ByVal value As Integer)
				_age = value
			End Set
		End Property
		Private privateGroup As Boolean
		Public Property Group() As Boolean
			Get
				Return privateGroup
			End Get
			Set(ByVal value As Boolean)
				privateGroup = value
			End Set
		End Property
		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
				Private privateParentId As Integer
				Public Property ParentId() As Integer
					Get
						Return privateParentId
					End Get
					Set(ByVal value As Integer)
						privateParentId = value
					End Set
				End Property
		Private privateBirthDate As DateTime
		Public Property BirthDate() As DateTime
			Get
				Return privateBirthDate
			End Get
			Set(ByVal value As DateTime)
				privateBirthDate = value
			End Set
		End Property
		Private privateSomeClasses As ObservableCollection(Of SomeClass)
		Public Property SomeClasses() As ObservableCollection(Of SomeClass)
			Get
				Return privateSomeClasses
			End Get
			Set(ByVal value As ObservableCollection(Of SomeClass))
				privateSomeClasses = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return FirstName
		End Function

		


	  End Class
End Namespace
