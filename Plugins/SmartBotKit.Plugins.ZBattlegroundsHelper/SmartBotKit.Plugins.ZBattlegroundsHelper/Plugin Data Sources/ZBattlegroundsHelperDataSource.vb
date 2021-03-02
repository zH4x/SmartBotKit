
#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports SmartBot.Plugins.API
Imports Xceed.Wpf.Toolkit.PropertyGrid.Attributes

#End Region

#Region " ZBattlegroundsHelperDataSource "

' ReSharper disable once CheckNamespace

Namespace PluginTemplate


    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Provides the collection of values represented by a ComboBox for the <see cref="ZBattlegroundsHelperData.TestProperty"/> property.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <seealso cref="IItemsSource"/>
    ''' ----------------------------------------------------------------------------------------------------
    Public NotInheritable Class ZBattlegroundsHelperDataSource : Implements IItemsSource

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Initializes a new instance of the <see cref="ZBattlegroundsHelperDataSource"/> class.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public Sub New()
        End Sub

#End Region

#Region " Public Methods "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the collection of values.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' The resulting <see cref="ItemCollection"/>.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        Public Function GetValues() As ItemCollection Implements IItemsSource.GetValues
            Return New ItemCollection From {
                Bot.Mode.Practice,
                Bot.Mode.RankedStandard,
                Bot.Mode.UnrankedStandard,
                Bot.Mode.RankedWild,
                Bot.Mode.UnrankedWild
            }
        End Function

#End Region

    End Class

End Namespace

#End Region
