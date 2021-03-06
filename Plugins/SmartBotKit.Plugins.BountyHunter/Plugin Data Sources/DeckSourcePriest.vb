﻿
#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports System.Linq

Imports SmartBot.Plugins.API
Imports Xceed.Wpf.Toolkit.PropertyGrid.Attributes

#End Region

#Region " DeckSourcePriest "

' ReSharper disable once CheckNamespace

Namespace BountyHunter


    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Provides the collection of values represented by a ComboBox for the <see cref="BountyHunterPluginData.DeckPriest"/> property.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <seealso cref="IItemsSource"/>
    ''' ----------------------------------------------------------------------------------------------------
    Public NotInheritable Class DeckSourcePriest : Implements IItemsSource

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DeckSourcePriest"/> class.
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
            Dim items As New ItemCollection From {
                {"None", "None"}
            }

            For Each deck As Deck In (From d As Deck In Bot.GetDecks() Where d.Class = Card.CClass.PRIEST)
                items.Add(deck.Name, deck.Name)
            Next deck

            Return items
        End Function

#End Region

    End Class

End Namespace

#End Region
