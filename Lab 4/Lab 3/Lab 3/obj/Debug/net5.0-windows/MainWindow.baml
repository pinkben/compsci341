   M S B A M L   `   `   `  ����@  <Lab 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab_3Lab_3  5   	   e aSystem.Collections.Specialized, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3awTclr-namespace:System.Collections.Specialized;assembly=System.Collections.SpecializedSystem.Collections.Specialized 5   	       Lab_3.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab_3     5   	   lSpecializedTclr-namespace:System.Collections.Specialized;assembly=System.Collections.Specialized     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��423* �6   �� 5      $	��11* �6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ TitleHeader��5      $��Crossword Entry Manager��6%   $��257,22,234,336q�6G   $��24(�6_   $��Center=�6m   $��Center=�6�   �� 5   
   -   5         ��Name$ ListAllEntriesButton��5      $��List All Entries��6/   $��126,98,492,266q�6J   $��18(�6b   6p   �� 5   
   -   5        $ AddEntryButton��5      $��	Add Entry��6)   $��126,162,492,202q�6=   $��18(�6V   6d   �� 5   
   -   5        $ UpdateEntryButton��5      $��Update Entry��6,   $��126,226,492,138q�6C   $��18(�6\   6j   �� 5   
   -   5        $ DeleteEntryButton��5      $��Delete Entry��6,   $��126,290,492,74q�6C   $��18(�6[   6i   �� 5   
   -   5        $ 
ExitButton��5      $
��Exit��6%   $��126,354,492,10q�64   $��18(�6L   6Z   �� 5   
   -   5         ��Name$ EntriesTextBox��5       �� TextWrapping$
 Wrap=�6*   $��425,98,89,0q�6>    �� 
IsReadOnly$
 True��6S   5      5      