Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace dxSampleGrid
	Public Class custConverter
		Inherits MarkupExtension
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim cd As EditGridCellData = TryCast(value, EditGridCellData)

			If cd IsNot Nothing Then
				Debug.Print(value.ToString())
			End If
			Return value
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return value
		End Function

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
	End Class
End Namespace
