   M S B A M L   `   `   `  ����Q  MBook management system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Book_management_systemBook_management_system  5   	   0    *Book_management_system.Change_book_details   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Book_management_system     5   	   -   5          �Name$  change_book��5   	    � Title$ Change_book_details��5   	   $��608.95��6%   $��491.2��65   
������� � WindowStyle$ 
ToolWindow=�6Z    � WindowStartupLocation$ CenterScreen=�6s   .��5	      � $��0,-1,-0.2,1q�6    � RowDefinitions 5
   
   �� 5      $
��181* �6   �� 5      $	��85* �6   .+�5   
   �� -   5         ��Name$ 	txt_title��5      $
��Left=�6%   $��21��6@   $��
100,23,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��300��6�   �� 5   
   $��title��6   $
��Left=�6    $��	16,20,0,0q�6;   $	��Top=�6N    J� RenderTransformOrigin$ 0.461,2.336&�6f   �� 5   
   $��Author��6   $
��Left=�6!   $��	13,64,0,0q�6<   $	��Top=�6O   $ 0.461,2.336&�6g   �� 5   
   -   5        $ 
txt_author��5      $
��Left=�6&   $��21��6A   $��
101,67,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��300��6�   �� 5   
   -   5        $ txt_publisher��5      $
��Left=�6)   $��21��6D   $��100,111,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��300��6�   �� 5   
   $��	Publisher��6   $
��Left=�6$   $��
10,108,0,0q�6?   $	��Top=�6S   $ 0.461,2.336&�6k   �� 5   
   $��description��6   $
��Left=�6&   $��	8,197,0,0q�6A   $	��Top=�6T   $ 0.461,2.336&�6l   �� 5   
   -   5        $ 	txt_descr��5      $
��Left=�6%   $	��104��6@   $��100,208,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��300��6�   �� 5   
   $
��Isbn��6   $
��Left=�6   $��	8,328,0,0q�6:   $	��Top=�6M   $ 0.461,2.336&�6e   �� 5   
   -   5        $ txt_isbn��5      $
��Left=�6$   $��21��6?   $��100,331,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��173��6�   �� 5   
   $��Genre��6   $
��Left=�6    $��	7,374,0,0q�6;   $	��Top=�6N   $ 0.461,2.336&�6f   $��2��6�   �� 5   
   -   5         ��Name$ 
comb_genre��5      $
��Left=�6'   $��100,376,0,0q�6B   $	��Top=�6W   $	��173��6o   $��2��6{   5      �� 5   
   -   5        $ 	txt_price��5      $
��Left=�6%   $��21��6@   $��324,331,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $��76��6�   6�   �� 5   
   $��Price��6   $
��Left=�6    $��280,329,0,0q�6;   $	��Top=�6P   $ 0.461,2.336&�6h   �� 5   
   -	   5        	 ��Name$	 btn_ok��5      $��OK��6!   $
��Left=�6.   $��160,124,0,0q�6I   $	��Top=�6^   $��75��6v   $��1��6�   ���	#FFFBF9F9$��22��6�   �� 5   
   -
   5        $	 
btn_cencel��5      $��Cencel��6%   $
��Left=�66   $��259,124,0,0q�6Q   $	��Top=�6f   $��75��6~   $��1��6�   
�������$��22��6�   �� 5    
   -   5        $ txt_quantitu��5       $
��Left=�6(   $��21��6C   $��100,156,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��124��6�   6�   �� 5!   
   $��Quantity��6   $
��Left=�6#   $��
10,153,0,0q�6>   $	��Top=�6R   $ 0.461,2.336&�6j   �� 5#   
   $��Date publish��6   $
��Left=�6'   $��4,26,0,0q�6B   $	��Top=�6T   $ 0.461,2.336&�6l   $��1��6�   (  "System.Windows.Controls.DatePicker  5$   
   -   5        
  Name$
 pic_publish_date��5$      $
��Left=�6/   $��
101,27,0,0q�6J   $��1��6^   $	��Top=�6k   $	��172��6�   |�.  $��23��6�   5&      5'      