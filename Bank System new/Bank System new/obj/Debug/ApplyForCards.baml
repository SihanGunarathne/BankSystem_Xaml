   M S B A M L   `   `   `  ����J  FBank System new, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Bank_System_newBank_System_new  5      #    Bank_System_new.ApplyForCards   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Bank_System_new     5        N� Title$  ApplyForCards��5	      .��5      � ��5   
   �� 5       �� Opacity$	 0.3Q�6    �� ImageSource$� �plus-button-and-credit-card-vector-stock-illustration-isolated-on-a-white-background-concept-of-opening-a-bank-account-or-paying-for-medical-services-2ABBM7H.jpg��6'    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��75 �6   �� 5      $��75 �6   �� 5      $��75 �6   �� 5      $��75 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��Type of Card��6   $��1��6'   $
��Left=�67   $��142,75,0,21.4q�6R   $��1��6i   $��center=�6v   ���	#FF7CE853$
��Bold"�6�   $��20(�6�   $��54��6�   $	��189��6�   $��2��6�   �� 5   
   $��Card no��6   $��1��6"   $
��Left=�62   $��142,74.8,0,20.6q�6M   $��2��6f   $��Center=�6s   ���	#FF7CE853$
��Bold"�6�   $��20(�6�   $��55��6�   $	��189��6�   $��2��6�   �� 5   
   $��1��6   $
��Left=�6#   $��
530,75,0,0q�6>   $��1��6R   $	��Top=�6_   $	��225��6w   $��49��6�   $��20(�6�   $��2��6�   .@�5      ��  �� 
IsSelected . .��6-   
ATM Card67   �� 5       .��6   Credit Card6(   �� 5!      .��6   
Debit Card6'   5#      �� 5$   
   $��1��6   $
��Left=�6#   $��55��6>   $��530,74.8,0,0q�6J   $��2��6`    �� TextWrapping$
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��230��6�   $��20(�6�   $��2��6�   �� 5%   
   $��Apply for Cards��6   $��1��6*   $
��Left=�6:   $��
218,10,0,0q�6U   $	��Top=�6i   $	��422��6�   ���	#FF0FD72E$��40(�6�   $
��Bold"�6�   �� 5&   
   -   5        $
��Back��5&      $��1��6    $
��Left=�60   $��679,0.4,0,0q�6K   $��4��6`   $	��Top=�6m   $��81��6�   ���	#FF4366B6���	#FF0B0752 J� OpacityMask �	#FF007BFF$��24(�6�   $
��Bold"�6�   $��56��6  �� 5'   
   -   5         ��Name$ Button2��5'   '   $��Submit��68   $��1��6I   $
��Left=�6Y   $��522,0.4,0,0q�6t   $��4��6�   $	��Top=�6�   $	��118��6�   ���	#FF4366B6���	#FF0B0752 �	#FF007BFF$��24(�6   $
��Bold"�6  $��56��6   	 J� RenderTransformOrigin$	 1.783,0.546&�6,  �� 5(   
   $��ACCOUNT NUMBER��6   $��1��6)   $
��Left=�69   $��	142,0,0,0q�6T   $��1��6g   $	��Top=�6t   $	 -0.458,1.463&�6�   $��55��6�   $	��189��6�   ���	#FF7CE853$��18(�6�   $
��Bold"�6�   �� 5)   
   $��1��6   $
��Left=�6"   $��55��6=   $��	530,0,0,0q�6I   $��1��6\   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��230��6�   $��18(�6�   5+      5,      