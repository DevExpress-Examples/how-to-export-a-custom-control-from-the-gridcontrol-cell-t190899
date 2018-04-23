Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Grid

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Threading
Imports DevExpress.Xpf.Charts

Namespace dxSampleGrid
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			vm = New MyViewModel()
			DataContext = vm

		End Sub
		Private vm As MyViewModel



		Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Dispatcher.BeginInvoke((Action)(() => {
			'    Debug.Print("sdf");
			'}), DispatcherPriority.Input);
			tableView1.ShowPrintPreview(Me)
		End Sub


	End Class


	Public NotInheritable Class Helper
        Public Shared ReadOnly ValueProperty As DependencyProperty = DependencyProperty.RegisterAttached("Value", GetType(Object), GetType(Helper), New PropertyMetadata(Nothing, AddressOf OnValuePropertyChanged))
		Private Sub New()
		End Sub
		Public Shared Function GetValue(ByVal obj As DependencyObject) As Object
			Return CObj(obj.GetValue(ValueProperty))
		End Function
		Public Shared Sub SetValue(ByVal obj As DependencyObject, ByVal value As Object)
			obj.SetValue(ValueProperty, value)
		End Sub
		Private Shared Sub OnValuePropertyChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			If Not(TypeOf e.NewValue Is Integer) Then
				Return
			End If
			Dim ps As PieSeries2D = TryCast(d, PieSeries2D)
			If ps Is Nothing Then
				Return
			End If
			ps.Points.Clear()
			ps.Points.Add(New SeriesPoint With {.Value = CInt(Fix(e.NewValue)), .Argument = "Missing"})
			ps.Points.Add(New SeriesPoint With {.Value = 1, .Argument = "EnteredAnotherStation"})
			ps.Points.Add(New SeriesPoint With {.Value = 1, .Argument = "Entered"})
		End Sub
	End Class





End Namespace
