   M S B A M L   `   `   `  ����Q  MBook management system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Book_management_systemBook_management_system  5   	   h dSAPBusinessObjects.WPF.Viewer, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304tRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.ViewerSAPBusinessObjects.WPF.Viewer 5   	   .    (Book_management_system.Generates_Reports   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Book_management_system     5   	   eViewerRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.Viewer     5   	     � Title$  Reports��5	   	   $��602.006��6   $��962.701��6*    � WindowStartupLocation$ CenterScreen=�6:   
������� � 
ResizeMode$ NoResize=�6v   .��5
      � .+�5   
   8  2SAPBusinessObjects.WPF.Viewer.CrystalReportsViewer  -   5          Name$ raport_view��5   &   $
��Left=�6;   $	��561��6V   $��	220,0,0,0q�6c   $	��Top=�6v   $	��725��6�      ShowLogo .  6�   �� 5   
   -   5         ��Name$ btn_prev��5      $��Preview��6#   $��8,503,749,17q�65   $��15(�6K   
�������6p   �� 5   
   -   5        $ btn_listofBook��5      $��List of Book��6)   $��10,21,749,499q�6@   $��15(�6W   
�������6�   �� 5   
   -   5         ��Name$ 
comb_genre��5      $
��Left=�6'   $��
12,133,0,0q�6B   $	��Top=�6V   $	��196��6n   5      �� 5   
   $��Genre:��6   $
��Left=�6!   $��
10,105,0,0q�6<   $	��Top=�6P   $
��Bold"�6h   �� 5   
   $��Publish Date:��6   $
��Left=�6(   $��
10,176,0,0q�6C   $	��Top=�6W   $
��Bold"�6o   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ pic_publish_date_start��5      $
��Left=�65   $��
10,228,0,0q�6P   $	��Top=�6d   $	��198��6|   |�.   � Language$ eu�6�   �� 5   
   $��Start Date:��6   $
��Left=�6&   $��
10,202,0,0q�6A   $	��Top=�6U   5      5      