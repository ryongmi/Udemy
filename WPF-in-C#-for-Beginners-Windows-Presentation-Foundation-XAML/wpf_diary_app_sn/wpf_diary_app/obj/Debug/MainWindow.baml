   M S B A M L   `   `   `  ����H  Dwpf_diary_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:wpf_diary_appwpf_diary_app  5   	       wpf_diary_app.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:wpf_diary_app     5   	   -   5          �Name$  main_window��5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowState$ 	Maximized=�6Z    � WindowStyle$
 None=�6r   ��5	      �� 5
   
    �� ImageSource$- 'pack://siteoforigin:,,,/Data/Pics/1.png��6   .��5      � .+�5   
   ]� ��.  .+�5      �� -   5         ��Name$ sidebar_panel��5      $	��150��6,   ��5      �� 5       �� Color$ 	#FF4E5E5F��6&    �� Opacity$	 0.4Q�68   .+�5      �� ���	#FFFFA21B
���   �$��4q�6D   $	��100��6X   $	��100��6e   	 �� CornerRadius$	 50��6q   
 �� Left$
 28��6�   
 �� Top$ 23��6�   ._�5      �� .+�5      �� -   5         ��Name$ time_lbl��5       $�� ��62   $ 21��6=   $��50��6M   $��92��6Y   $��20(�6d   ���	#FFFFA21B
���   �$��Center=�6�   $��Center=�6�   5      5      �� 5      -   5        $ 	cal_panel��5      $	��120��6,   $	��130��68   $	 150��6E   $
 17��6V   ��5      �� 5      $! Data/Other_Img/calander.png��6%   .+�5      �� -   5        $ year_lbl��5      $ 27��6.   $
 5��6>   $��Center=�6N   $��Center=�6p   $
��Bold"�6�   $��13(�6�   
�������6�   �� 5      -   5        $ 	month_lbl��5      $ 27��6/    �� Right$ 20��6?   $��Center=�6Q   $��Center=�6s   $
��Bold"�6�   $��13(�6�   
�������6�   �� 5      -   5        $ day_in_month_lbl��5      $ 55��66   $
 40��6F   $��Center=�6W   $��Center=�6y   $
��Bold"�6�   $��23(�6�   �� 5      -   5        $ day_in_week_lbl��5       �� Bottom$ 10��65   $
 35��6H   $��Center=�6Y   $��Center=�6{   $
��Bold"�6�   $��15(�6�   5      5       �� 5!      -	   5        $ 	top_panel��5!      $��67��6(   $	��Top=�64   ��5"      �� 5#      $ 	#FF49684C��6&   $
 0.25Q�68   5%      �� 5&      -
   5        $ bottom_panel��5&      $��Bottom=�6+   $��25��6C   ��5'      �� 5(      $ 	#FF8F5858��6&   $
 0.35Q�68   .+�5*      �� $��Background:��6   ��5+      �� 5,      $ 	#FF9C7878��6*   $	 0.4Q�6<   5.      �� 5/      -   5         ��Name$ pic_cbox��5/      $
 80��6-   $ 2��6>   $��80��6M    � Cursor$
 Hand��6X   .@�50      �� $��Image 1��6#   $
��Left=�65   $��94��6P   �� 51      $��Image 2��6#   $
��Left=�65   $��94��6P   �� 52      $��Image 3��6#   $
��Left=�65   $��94��6P   53      54      55      �� 56   
   -   5        $��close��56      $
��Left=�6!   $��281,212,0,0q�6<   $	��Top=�6Q   $��75��6i   6t   58      59      