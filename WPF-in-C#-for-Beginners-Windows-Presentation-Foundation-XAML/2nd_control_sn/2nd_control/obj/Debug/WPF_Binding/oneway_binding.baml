   M S B A M L   `   `   `  ����F  B2nd_control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:_2nd_control.WPF_Binding_2nd_control.WPF_Binding  5   	   -    '_2nd_control.WPF_Binding.oneway_binding   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:_2nd_control.WPF_Binding     5   	     � Title$  oneway_binding��5   	   $	��450��6    $	��800��6-    � 	Resources 5	          BooleanToVisibilityConverter��%   &	        �� 5
   
   6'   5      .��5      � .+�5   
   �� -   5         ��Name$ 	my_slider��5      $
��Left=�6$   $��	85,89,0,0q�6?   $	��Top=�6R   $	��321��6j    � Maximum$	 100Q�6v    �� TickPlacement$ TopLeft=�6�    �� TickFrequency$ 5Q�6�    � SmallChange$ 5Q�6�    � LargeChange$ 10Q�6�   �� 5   
   -   5         ��Name$ my_tb��5      $
��Left=�6!   $��23��6<   $��
411,90,0,0q�6H   	 �� TextWrapping$
	 Wrap=�6\   $	��Top=�6p   $��57��6�   ��6�   �� *Value+
 �� ElementName$
 	my_slider�� �� Mode$ OneWay=�� 5   
   -   5         �Name$ my_prog_bar��5      $
��Left=�6+   $��25��6F   $��
85,160,0,0q�6R   $	��Top=�6f   $	��321��6~    � Value 6�   �� *Value+$
 	my_slider��$ OneWay=��� 5   
   -   5         ��Name$ my_btn��5      $��Test Button��6!   $
��Left=�67   $��
85,242,0,0q�6R   $	��Top=�6f   $	��142��6~   $��44��6�   {�6�   �� *	IsChecked+$
 enable_cbox_btn��$ OneWay=�y�6�   �� *	IsChecked+ �� 	Converter# [  $
 show_hide_btn��$ OneWay=��� 5   
   -   5         ��Name$ enable_cbox_btn��5      $��Enable / Disable Button��6,   $
��Left=�6N   $��
85,311,0,0q�6i   $	��Top=�6}    d� 	IsChecked$
 TrueY�6�   �� 5   
   -   5        $ show_hide_btn��5      $��Show/Hide Button��6*   $
��Left=�6E   $��
85,344,0,0q�6`   $	��Top=�6t   5      5      