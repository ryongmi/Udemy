   M S B A M L   `   `   `  ����F  B2nd_control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:_2nd_control.WPF_Binding_2nd_control.WPF_Binding  5   	   ,    &_2nd_control.WPF_Binding.string_format   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:_2nd_control.WPF_Binding     5   	     � Title$  string_format��5   	   $��189.426��6   $��604.348��60   .��5	      � .+�5
   
   �� -   5         ��Name$ my_tb��5
      $
��Left=�6!   $��23��6<   $��
359,41,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6�   $	��218��6�    J� RenderTransformOrigin$ 0.974,0.132&�6�   ��6p   ��  �� Path$ Value� �� ElementName$ 	my_slider�� �� Mode$ OneWay=� �� StringFormat$ {0:F0}��6�   �� 5   
   -   5         ��Name$ 	my_slider��5      $
��Left=�6$   $��	53,41,0,0q�6?   $	��Top=�6R   $	��301��6j   	 �� TickFrequency$		 500Q�6v   
 �� TickPlacement$
 TopLeft=�6�    � Maximum$ 20000Q�6�   �� 5   
   -   5         ��Name$ my_lbl��5      $
��Left=�6^   $��
359,85,0,0q�6y   $	��Top=�6�   $	��218��6�    �� ContentStringFormat$ N0��6�   ��6    �� *Value+$ 	my_slider��$ OneWay=�6�   5      5      