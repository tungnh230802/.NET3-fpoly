   M S B A M L   `   `   `  ����A  =Bai1_B, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Bai1_BBai1_B  5   	       Bai1_B.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Bai1_B     5   	   -   5          � Title$  
MainWindow��5   	   $	��425��6   $	��700��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � $��Bottom=�6   $	��394��6&    � ColumnDefinitions 5
   
   �� 5      $	��93* �6   �� 5      $
��599* �6   .+�5   
   �� $��26(�6   $
��Bold"�6"   $
��Left=�64   $��
111,37,0,0q�6O   $
��Wrap=�6c   $!��Chương Trình tính Toán��6w   $	��Top=�6�   $��1��6�   �� 5   
   $
��Left=�6   $��
83,137,0,0q�6/   $
��Wrap=�6C   $��Số: ��6W   $	��Top=�5       J� RenderTransformOrigin$ -2.531,1.125&�6   $��2��6@   �� 5   
   -   5         ��Name$ txb_num��5      $
��Left=�6#   $��23��6>   $��
56,137,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��168��6�   $��1��6�   �� 5   
   $
��Left=�6   $��
83,205,0,0q�6/   $
��Wrap=�6C   $��Kết quả:��6W   $	��Top=�6g   $��2��6   �� 5   
   -   5        $ 
txb_result��5   $   {�.  $
��Left=�68   $��23��6S   $��
56,204,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��219��6�   $��1��6�   �� 5   
   -   5         ��Name$ btn_bp��5      $��Bình Phương��6!   $
��Left=�67   $��373,107,0,0q�6R   $	��Top=�6g   $	��118��6   $ -0.027,0.45&�6�   $��33��6�   $��1��6�   6�   �� 5   
   -   5        $ btn_lp��5      $��Lập Phương��6!   $
��Left=�66   $��373,153,0,0q�6Q   $	��Top=�6f   $	��118��6~   $ -0.027,0.45&�6�   $��33��6�   $��1��6�   6�   �� 5   
   -   5        $ btn_gt��5      $��Giai Thừa��6!   $
��Left=�65   $��373,204,0,0q�6P   $	��Top=�6e   $	��118��6}   $ -0.027,0.45&�6�   $��33��6�   $��1��6�   6�   �� 5   
   -   5        $ Thoát��5      $��Thoát��6    $
��Left=�60   $��282,255,0,0q�6K   $	��Top=�6`   $	��118��6x   $ -0.027,0.45&�6�   $��33��6�   $��1��6�   6�   5      5      