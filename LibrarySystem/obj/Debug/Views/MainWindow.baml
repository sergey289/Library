   M S B A M L   `   `   `  ����Q  MBook management system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Book_management_systemBook_management_system  5   	   '    !Book_management_system.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Book_management_system     5   	     � Title$  
MainWindow��5   	   $��544.297��6   $��924.138��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��47* �6   �� 5      $
��870* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	data_grid��5      $
��Left=�6&   $	��420��6A   $��5,83,0,0q�6N   $	��Top=�6`   $	��903��6x      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�   $��2��6�   �� 5   
   -   5         ��Name$ btn_add��5      $
��Left=�6#   $��	29,20,0,0q�6>   $	��Top=�6Q   $��45��6i   $��46��6t   
������ 
������  J� RenderTransformOrigin$ 1.731,1.134&�6�   $��2��6�   ��5      �� 5       �� Orientation$ 
Horizontal=�6   $ 
1.036,0.91&�66   .+�5      �� $J��D/Book management system;component/Resources/images/book_PNG51090.png��6   $��35��6j   $��37��6v   5      5      �� 5   
   $��Add Book��6   $
��Left=�6#   $��	17,60,0,0q�6>   $	��Top=�6Q   $ 1.151,0.718&�6i   $��2��6�   �� 5   
   -   5        $ 
btn_change��5      $
��Left=�6&   $��61.8,25,0,0q�6A   $	��Top=�6V   $��34��6n   $��37��6y   
������ 
������ $ 1.731,1.134&�6�   $��1��6�   ��5      �� 5"      $ 
Horizontal=�6   $ 
1.036,0.91&�66   .+�5#      �� $C��=/Book management system;component/Resources/images/change.png��6   5%      5)      �� 5*   
   $��Change��6   $
��Left=�6!   $��54.8,60,0,0q�6<   $	��Top=�6Q   $ 1.151,0.718&�6i   $��28��6�   $��51��6�   $��1��6�   �� 5+   
   -   5        $ 
btn_remove��5+      $
��Left=�6&   $��140.8,25,0,0q�6A   $	��Top=�6W   $��32��6o   $��32��6z   
������ 
������ $ 1.731,1.134&�6�   $��1��6�   .��5.      �� $ 
Horizontal=�6   $ 
1.036,0.91&�62   .+�5/      �� $D��>/Book management system;component/Resources/images/remove2.png��6   $��30��6`   $��28��6l   51      54      �� 55   
   -   5        $ 
btn_search��55      $
��Left=�6&   $��214.8,25,0,0q�6A   $	��Top=�6W   $��33��6o   $��35��6z   
������ 
������ $ 1.731,1.134&�6�   $��1��6�   .��58      �� $ 
Horizontal=�6   $ 
1.036,0.91&�62   .+�59      �� $O��I/Book management system;component/Resources/images/search-png-icon-21.jpg��6   $��35��6k   $��29��6w   5;      5>      �� 5?   
   $��Remove��6   $
��Left=�6!   $��129.8,60,0,0q�6<   $	��Top=�6R   $ 1.151,0.718&�6j   $��23��6�   $��1��6�   �� 5@   
   -   5        $ btn_filtter��5@      $
��Left=�6'   $��289.8,25,0,0q�6B   $	��Top=�6X   $��34��6p   $��35��6{   
������ 
������ $ 1.731,1.134&�6�   $��1��6�    � ContextMenu 5B      �� 5C      -   5         ��Name$ cc��5C      .@�5D      m� $��Genre��6   .@�5E      m� -   5        	 m�Name$	 item1��5E   $   $��Fantasy��63   6D   m� 5F      -	   5        $	 item2��5F   $   $��Romance��63   6D   m� 5G      -
   5        $	 item3��5G   $   $��	Adventure��64   6G   m� 5H      -   5        $	 item4��5H   $   $��Mystery��63   6D   m� 5I      -   5        $	 item5��5I   $   $	��All��63   6@   5J      �� 5L      5N      .��5R      �� $ 
Horizontal=�6   $ 
1.036,0.91&�62   .+�5S      �� $D��>/Book management system;component/Resources/images/fillter.png��6   $��28��6`   $��27��6l   5U      5X      �� 5Y   
   -   5        $ 
btn_raport��5Y      $
��Left=�6&   $��360.8,25,0,0q�6A   $	��Top=�6W   $��41��6o   $��38��6z   
������ 
������ $ 1.731,1.134&�6�   $��1��6�   .��5\      �� $ 
Horizontal=�6   $ 
1.036,0.91&�62   .+�5]      �� $C��=/Book management system;component/Resources/images/raport.png��6   $��35��6_   $��38��6k   5_      5b      �� 5d   
   $��Search��6   $
��Left=�6!   $��206.8,60,0,0q�6<   $	��Top=�6R   $ 1.151,0.718&�6j   $��23��6�   $��1��6�   �� 5e   
   $��Fillter ��6   $
��Left=�6#   $��288.8,60,0,0q�6>   $	��Top=�6T   $ 1.151,0.718&�6l   $��23��6�   $��1��6�   �� 5f   
   $��Raport ��6   $
��Left=�6"   $��357.8,60,0,0q�6=   $	��Top=�6S   $ 1.151,0.718&�6k   $��26��6�   $��46��6�   $��1��6�   5h      5i      