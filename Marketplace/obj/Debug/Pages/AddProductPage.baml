   M S B A M L   `   `   `  ����F  BMarketplace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Marketplace.PagesMarketplace.Pages  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5
      &     Marketplace.Pages.AddProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Marketplace.Pages     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5
        N� Title$  AddProductPage��5	       � 	Resources 5         ComboBox.Static.Background �� EndPoint �� 
StartPoint � Color � Offset  ComboBox.Static.Border �� Color  ComboBox.Static.Glyph ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border 	 ComboBox.MouseOver.Glyph *
 &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Background  ComboBox.Pressed.Border  ComboBox.Pressed.Glyph ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border   ComboBox.Disabled.Background  ComboBox.Disabled.Border  ComboBox.Disabled.Glyph ) %ComboBox.Disabled.Editable.Background % !ComboBox.Disabled.Editable.Border 0 ,ComboBox.Disabled.Editable.Button.Background , (ComboBox.Disabled.Editable.Button.Border  ComboBoxToggleButton �� 
TargetType �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels F�Name �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value �� 
TargetName P� Property P� Value  ComboBoxTemplate1 �Name � ColumnDefinitions �Name � AllowsTransparency �� Mode5  /Microsoft.Windows.Themes.SystemDropShadowChrome  Name   Color �� MaxDropDownHeight  �� ElementName! ��Name" �� ClearTypeHint# ��Name$ ��Name% ��Name-  'System.Windows.Input.KeyboardNavigation&   DirectionalNavigation' d�Name( d� 	IsChecked) ��Name#* �� SelectionBoxItemStringFormat+ �� ContentStringFormat, �� SelectionBoxItemTemplate- �� SelectionBoxItem. J� IsHitTestVisible/ P� 
SourceName0 ]� 
Conditions1 �� Property��%  &	        &	 �     &	 �     &	 �     &	 �     &	     &	 =    &	 `    &	 �    &		     &	
 9    &	 W    &	 u    &	     &	 ,    &	 �    &	 �    &	      &	     &	 A    &	 �    &	 �    &	     &	 -    &	 K    &	 i    &	 �    &	 �    &	 �    7  7  7  7  7  7  7 	 7  7  7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 �    7  �� 5   
   $	 0,1&�6A   $	 0,0&�6P   .��5      � $ 	#FFF0F0F0��6   $	 0.0Q�6-   � 5      $ 	#FFE5E5E5��6   $	 1.0Q�6-   5      �� 5   
   $ 
Aquamarine��69   �� 5   
   $ Black��68   �� 5   
   $ Bisque��6F   �� 5   
   $ Black��6B   �� 5   
   $ Wheat��6M   �� 5   
   $ 	Turquoise��6I   �� 5   
   $	 0,1&�6D   $	 0,0&�6S   .��5      � $ 	#FFECF4FC��6   $	 0.0Q�6-   � 5      $ 	#FFDCECFC��6   $	 1.0Q�6-   5      �� 5   
   $
 Aqua��6<   �� 5   
   $ Azure��6;   �� 5   
   $
 Aqua��6I   �� 5   
   $
 Aqua��6E   �� 5   
   $	 0,1&�6T   $	 0,0&�6c   .��5       � $
 Aqua��6   $	 0.0Q�6(   � 5!      $ Beige��6   $	 1.0Q�6)   5"      �� 5#   
   $ 
Aquamarine��6L   �� 5$   
   $	 0,1&�6B   $	 0,0&�6Q   .��5%      � $ 
Aquamarine��6   $	 0.0Q�6.   � 5&      $
 Aqua��6   $	 1.0Q�6(   5'      �� 5(   
   $
 Aqua��6:   �� 5)   
   $
 Aqua��69   �� 5*   
   $
 Aqua��6G   �� 5+   
   $ 	#FF569DE5��6C   �� 5,   
   $	 0,1&�6R   $	 0,0&�6a   .��5-      � $
 Aqua��6   $	 0.0Q�6(   � 5.      $
 Aqua��6   $	 1.0Q�6(   5/      �� 50   
   $
 Aqua��6J   �� 51   
   $
 Aqua��6?   �� 52   
   $
 Aqua��6;   �� 53   
   $
 Aqua��6:   �� 54   
   $
 Aqua��6H   �� 55   
   $
 Aqua��6D   �� 56   
   $ Violet��6O   �� 57   
   $ Violet��6K   �� 58   
   " d�6-   .�59      ��  �@�OverridesDefaultStyle	 . 66   �� 5:       � ��	 .  6*   �� 5;       � |�	 .  6*   �� 5<       �@��	ClickMode$	 Press=�6*   �� 5=       � ��	 5>      �� 5?      "
 d�6&   .R�5@      �� $ templateRoot��62   $ 5��6!   
�������8��  #��z��6�    . ._�5A      �� $ splitBorder��6%   
������ $��1q�6T   $��Right=�6h   $��0q�6�    . #��� r�6�   ._�5B   "   F� $ arrow��6'   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5C      5D       5E      ^� 5F       5G   "   �� 5H   &    60   �� *
IsEditable+ �� " �� true6�   �� 5I   &    60   �� *IsMouseOver+ �� *Self+	 false6v   �� 5J   &    60   �� *	IsPressed+ �� *Self+	 false6t   �� 5K   &    60   �� *	IsEnabled+ �� *Self+ true6t   .0�5M   "   �� $ templateRoot��6?   8	   � ��6Y   �� 5N   "   $ templateRoot��6@   8	   � ��6Z   �� 5O   "   $ splitBorder��6?   8	   � ��6X   �� 5P   "   $ splitBorder��6@   8	   � ��6Y   5Q      P� 5R       �@J�IsMouseOver . . �5S   "   �� $ arrow��69   8	   � ��6L   5T      ^� 5U       5V   "   �� 5W   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5X   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5Z   "   �� $ templateRoot��6?   8	   � ��6Y   �� 5[   "   $ templateRoot��6@   8	   � ��6Z   5\      ^� 5]       5^   "   �� 5_   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5`   &    60   �� *
IsEditable+ �� " �� true6�   .0�5b   "   �� $ templateRoot��6?   8	 	  � ��6Y   �� 5c   "   $ templateRoot��6@   8	 
  � ��6Z   �� 5d   "   $ splitBorder��6?   8	   � ��6X   �� 5e   "   $ splitBorder��6@   8	   � ��6Y   5f      P� 5g       � �� . . �5h   "   �� $ arrow��69   8	   � ��6L   5i      ^� 5j       5k   "   �� 5l   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5m   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5o   "   �� $ templateRoot��6?   8	   � ��6Y   �� 5p   "   $ templateRoot��6@   8	   � ��6Z   5q      ^� 5r       5s   "   �� 5t   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5u   &    60   �� *
IsEditable+ �� " �� true6�   .0�5w   "   �� $ templateRoot��6?   8	   � ��6Y   �� 5x   "   $ templateRoot��6@   8	   � ��6Z   �� 5y   "   $ splitBorder��6?   8	   � ��6X   �� 5z   "   $ splitBorder��6@   8	   � ��6Y   5{      P� 5|       � {� .  . �5}   "   �� $ arrow��69   8	   � ��6L   5~      ^� 5       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5�   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5�   "   �� $ templateRoot��6?   8	   � ��6Y   �� 5�   "   $ templateRoot��6@   8	   � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8	   � ��6Y   �� 5�   "   $ templateRoot��6@   8	   � ��6Z   �� 5�   "   $ splitBorder��6?   8	   � ��6X   �� 5�   "   $ splitBorder��6@   8	   � ��6Y   5�      5�      5�      5�      �� 5�   
   "
 ��64   .R�5�      � $ templateRoot��6    .  5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6    . $��2��6F   $��1q�6�   $��Bottom=�6�   #��� .�6�   ��6Z   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+.��5�        $ shadow��63   $ Transparent��6C   #��z 6�   ��6W   �� *ActualWidth+$  templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   #��� ��6   $��1q�6�   ._�5�      �� $! DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $" Enabled=�65   .+�5�   &   �� $# canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $$ 
opaqueRect��64   ��6H   �� *
Background+$  dropDownBorder����6�   �� *ActualHeight+$  dropDownBorder����6�   �� *ActualWidth+$  dropDownBorder��5�   '   �� 5�   &   $% ItemsPresenter��65   $& 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $' toggleButton��6   #��z��65   #��z��6_   #��z��6�   $��2��6�   8��  ( 6�   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+66  �� 5�      $) contentPresenter��6#   #+ z* 6=   #��z, 6�   #��z- 6�   #��z��6�   #��z��6-  . .  #��z��6�  # z 6�  #��z��6�  5�       5�      P� 5�      $/ 
PART_Popup��63    �@�HasDropShadow . . �5�      �� $ shadow��6/    � ��$	 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$	 #9999��6B   5�      P� 5�       �@��HasItems .  . �5�      �� $ dropDownBorder��6/    � ��$	 95��6K   5�      ]� 5�      0 5�      �� 5�      1 �@��
IsGrouping . 6:   �� 5�      "1 �@%�IsVirtualizingWhenGrouping .  6\   ./�5�      ��  � ��	 .  6F   5�      P� 5�      $/ DropDownScrollViewer��6C    � �� .  . �5�      �� $ 
opaqueRect��63   	 6K   �� *VerticalOffset+$  DropDownScrollViewer�� �@��Top�� 5�      $ 
opaqueRect��64   	 6L   �� *HorizontalOffset+$  DropDownScrollViewer�� �@��Left5�      5�      5�      .��5�      �  5�   
   �� 5�      �� 5�      .+�5�   
   �� $��10q�6   .+�5�      �� $��Title��6   �� 5�      -   5        2 ��Name$2 TitleTb��5�      ��5�      �� *Title+�� 5�      $��Price��6   �� 5�      -   5        $2 PriceTb��5�      ��5�      �� *Price+5�      �� 5�      $��Description��6   �� 5�      -   5        $2 DescTb��5�      $��50��5�      3 �� TextWrapping$
3 Wrap=�5�      ��5�      �� *Description+5�      �� 5�      $��Count��6   �� 5�      -   5        $2 CountTb��5�      ��5�      �� *Count+5�      �� 5�      $��Provider��6   �� 5�      -   5        4 ��Name$4 CbProviders��5�   E   #��[ 6   5 �� DisplayMemberPath$5 Title��5�      6 �� SelectedItem6 5�      �� *
Provider+�� 5�      $
��Type��6   �� 5�      -   5        $4 CbType��5�      #���  6(   $5 Title��5�      6 5�      �� *TypeProduct+�� 5�      -   5        7 ��Name$7 SaveBt��5�      $
��save��5�      5�      �� 5�      -   5        $7 CancelBt��5�      $��cancel��5�      5�      5�      ]� 5�   
   $��1��6   .+�5�      �� -	   5        $
7 ImBt��5�      $��addimage��6#   $��Bottom=�5�      5�      �� 5�      -
   5        8 ��Name$8 LVPhoto��5�      ��5�      �� 5�      .R�5�      � 5�      ��5�      �� 5�      .R�5�      �� $	��150��5�   !   9 �� BitmapScalingMode$
9 Fant=�5�   !   ��5�       �� *Photo+5�   !   5�      5�      5�      5�      5      