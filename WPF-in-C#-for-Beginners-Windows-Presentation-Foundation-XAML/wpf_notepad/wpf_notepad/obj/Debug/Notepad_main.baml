   M S B A M L   `   `   `  ����F  Bwpf_notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:wpf_notepadwpf_notepad  5   	       wpf_notepad.Notepad_main   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:wpf_notepad     5   	     � Title$  WPF Notepad Application��5   	   $��425.988��6)   $��641.701��6:    � WindowStartupLocation$ CenterScreen=�6J   .��5	      � ���	#FFFBCECE.+�5
   
   �� -   5         ��Name$ tb_ctl��5
      $��
10,43,10,5q�6"   $��TextBox��66   " �� VerticalScrollBarVisibility$ Visible=�6E    �� TextWrapping$
 Wrap=�6k    �� AcceptsReturn . 6   o� 5   
   $��38��6   $	��Top=�6   ���	#FFDED3D3.@�5      m� $��_File��6   $��38��6&   $��80��62    � Cursor$
 Hand��6=   .@�5      m� -   5         m�Name$ 	mitem_new��5      $	��New��6.   $
��Left=�6;   $��38��6V   $	��140��6b   6n   m� 5      -   5        $ 
mitem_open��5      $
��Open��6/   $
��Left=�6=   $��38��6X   $	��140��6d   6p   m� 5      -   5        $ mitem_save_as��5      $��Save As��62   $
��Left=�6C   $��38��6^   $	��140��6j   6v   m� 5      -   5        $ 
mitem_exit��5      $
��Exit��6/   $
��Left=�6=   $��38��6X   $	��140��6d   6p   5      m� 5      $��_Edit��6   $��38��6&   $��80��62   $
 Hand��6=   .@�5      m� -   5        $ 
mitem_undo��5      $
��Undo��6/   $
��Left=�6=   $��38��6X   $	��140��6d   6p   m� 5      -   5        $ 
mitem_redo��5      $
��Redo��6/   $
��Left=�6=   $��38��6X   $	��140��6d   6p   m� 5      -   5        $ 	mitem_cut��5      $	��Cut��6.   $
��Left=�6;   $��38��6V   $	��140��6b   6n   m� 5      -	   5        $ 
mitem_copy��5      $
��Copy��6/   $
��Left=�6=   $��38��6X   $	��140��6d   6p   m� 5      -
   5        $ mitem_paste��5      $��Paste��60   $
��Left=�6?   $��38��6Z   $	��140��6f   6r   m� 5      -   5        $ mitem_select_all��5      $��
Select All��65   $
��Left=�6I   $��38��6d   $	��140��6p   6|   5      m� 5      $��F_ormat��6   $��38��6(   $��80��64   $
 Hand��6?   .@�5      m� -   5        $ 
mitem_wrap��5      $��	Word Wrap��6/   $
��Left=�6B   $��38��6]   $	��150��6i    m� IsCheckable . 	 m� 	IsChecked	 . 6�   5      m� 5      $��_View��6   $��38��6&   $��80��62   $
 Hand��6=   .@�5      m� -   5        $ mitem_zoom_in��5      $��	Zoom In +��62   $
��Left=�6E   $��38��6`   $	��160��6l   6x   m� 5      -   5        $ mitem_zoom_out��5      $��
Zoom Out -��63   $
��Left=�6G   $��38��6b   $	��160��6n   6z   m� 5       -   5        $ mitem_zoom_default��5       $��Default Zoom��67   $
��Left=�6M   $��38��6h   $	��160��6t   6�   5!      m� 5"      $��_Help��6   $��38��6&   $��80��62   $
 Hand��6=   .@�5#      m� -   5        $ mitem_about_as��5#      $��About As��63   $
��Left=�6E   $��38��6`   $	��140��6l   5$      5%      5'      5(      