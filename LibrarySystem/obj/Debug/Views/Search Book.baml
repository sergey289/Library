   M S B A M L   `   `   `  ����Q  MBook management system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Book_management_systemBook_management_system  5   	   (    "Book_management_system.Search_Book   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Book_management_system     5   	     � Title$  Search_Book��5   	   $��441.409��6   $��440.8��6/   
������� � WindowStyle$ 
ToolWindow=�6T    � WindowStartupLocation$ CenterScreen=�6m   .��5	      � $��0,-1,-0.2,100.8q�6    � RowDefinitions 5
   
   �� 5      $
��181* �6   �� 5      $	��85* �6   .+�5   
   �� -   5         ��Name$ 	txt_title��5      $
��Left=�6%   $��20��6@   $��	75,48,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��300��6�   �� 5   
   $��title��6   $
��Left=�6    $��	14,45,0,0q�6;   $	��Top=�6N    J� RenderTransformOrigin$ 0.461,2.336&�6f   �� 5   
   $��Author��6   $
��Left=�6!   $��	11,90,0,0q�6<   $	��Top=�6O   $ 0.461,2.336&�6g   �� 5   
   -   5        $ 
txt_author��5      $
��Left=�6&   $��20��6A   $��	75,93,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��300��6�   �� 5   
   -   5        $ txt_publisher��5      $
��Left=�6)   $��20��6D   $��
75,133,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��300��6�   �� 5   
   $��	Publisher��6   $
��Left=�6$   $��
10,130,0,0q�6?   $	��Top=�6S   $ 0.461,2.336&�6k   �� 5   
   $
��Isbn��6   $
��Left=�6   $��
11,177,0,0q�6:   $	��Top=�6N   $ 0.461,2.336&�6f   �� 5   
   -   5        $ txt_isbn��5      $
��Left=�6$   $��20��6?   $��
75,180,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��182��6�   �� 5   
   -   5         ��Name$ 
btn_search��5      $��Search��6%   $
��Left=�66   $��130,138.2,0,-65.2q�6Q   $	��Top=�6l   $��75��6�   $��1��6�   ���	#FFF9F9F9$��22��6�   �� 5   
   -   5        $ 
btn_cencel��5      $��Cencel��6%   $
��Left=�66   $��229,138.2,0,-65.2q�6Q   $	��Top=�6l   $��75��6�   $��1��6�   
�������$��22��6�   5      5      