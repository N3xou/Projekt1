   M S B A M L   `   `   `  ����C  ?Projekt1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Projekt1Projekt1  5   	       Projekt1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Projekt1     5   	   $	��450��5   
   $	��800��6   $	��450��6#   $	��800��63   .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��50* �6   �� 5      $	��50* �6    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��7* �6   .+�5   
   �� -   5        $
��Menu��5      $	��400��67   $��0,0,0,0q�6C   $��0��6U   $��1��6b   $��Stretch=�6r   $��Stretch=�6�   ��5      �� 5       �� ImageSource$= 7C:\Users\Yami\Desktop\x\Projekt1\img\FriedChickenJ.jfif��6    j� Stretch$
 Fill=�6c   ��5      �� 5      $��6q�6   ���#2c3e50 �� CornerRadius$ 30��6C   ���#3498db �� Padding$ 20q�6j   ._�5      �� -   5         ��Name$ TextMenu��5       $
��Menu��62   $��30(�6>   $
��Bold"�6L   
�������6^   5      5      �� 5   
   -   5        $��CompletedOrders��5      $	��400��6G   $��0,0,0,0q�6S   $��0��6d   $��Stretch=�6r   $��Stretch=�6�   ��5      �� 5      $7 1C:\Users\Yami\Desktop\x\Projekt1\img\Calendar.jpg��6   $
 Fill=�6]   ��5!      �� 5"      $��6q�6   ���#2c3e50$ 30��6C   ���#3498db$ 20q�6j   ._�5#      �� -   5        $ TextCompletedOrders��5#   8   $��Completed Orders��6    $��26(�6U   $
��Bold"�6c   
�������6u   5$      5&      &   System.Windows.Controls.DataGrid  5'   
   -   5        $��MainGrid��5'      $��0,0,0,0q�6<   $��18(�6M   $��2��6[   $��1��6o      AutoGenerateColumns .     CanUserAddRows .  ��6$   �� 	   Columns	 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      
   FontSize$
 22Q�6%   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 4* 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *id+   Header 5*      �� 5+      -   5        $ TextID��5+   .   $��ID��6$   6.   5-        50      $ 4* 6%    60   �� *time+ �� StringFormat$ 	{0:HH:mm}�� 51      �� 52      -   5        $ TextOrderTime��52   6   $��
Order Time��6$   66   54      4  .System.Windows.Controls.DataGridTemplateColumn  55      $ 3* 6)    56      �� 57      -   5        $ TextDetails��57   3   $��Details��6$   63      CellTemplate 59      �� 5:       �� DataType$ Button��6'   
BtnDetails��.R�5;      �� -	   5        ��5<   "   �� 5=   &   ��60   �� *TextBtnDetails+5A      5B      5D        5E      $ 3* 6)    5F      �� 5G      $��x��6$    5I      �� 5J      $ Button��6'   	BtnFinish��.R�5K      �� -
   5         � DataContext 5K   :   �� ��5L   "   �� 5M   &   ��60   �� *TextBtnComplete+5O      5P      5R       � 	Resources 5T      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value�� 5U      %�   '        �� 5V      "  6:   .�5W      ��  � ��
 �   �67   �� 5X       � �� 67   Z� �� 5Y       � �� 68   Z� 5Z      5[      5]      �� 5^   
   -   5        $��ButtonLangPL��5^   .   $��1��6   $��2��6   ���#3498db$��5q�5_      $��50��6   $��50��6(   $��Bottom=�63   $��Right=�6N    K� ZIndex$ 1��6j   ��5`      �� 5b      $5��/C:\Users\Yami\Desktop\x\Projekt1\img\FlagPL.png��6   $
��Fill=�6Q   5d      �� 5e   
   -   5        $��ButtonLangEng��5e   .   $��1��6   $��2��6   ���#3498db$��0,5,70,5q�5f      $��50��6#   $��50��6/   $��Bottom=�6:   $��Right=�6U   $ 1��6q   ��5g      �� 5h      $6��0C:\Users\Yami\Desktop\x\Projekt1\img\FlagENG.png��6   $
��Fill=�6R   5j      5k      5l      