   M S B A M L   `   `   `  ����P  LIsAdditive_Attributes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:IsAdditive_AttributesIsAdditive_Attributes  5   	   &     IsAdditive_Attributes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:IsAdditive_Attributes     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� $��20q�6   .+�5      �� -   5        $��withIsAdditive��5      $	��100��5      $��20��6   $��12,0,0,5q�6   ���	#AA3333FF$
��Left=�6B   �� 5      -   5        $��withoutIsAdditive��5      $	��100��5      $��20��6   $��12,0,0,5q�6   ���	#AA3333FF$
��Left=�6B   �� 5      -   5        $"��withIsAdditiveUsingKeyFrames��5      $	��100��5      $��20��6   $��12,0,0,5q�6   ���	#AA3333FF$
��Left=�6B   �� 5      -   5        $%��withoutIsAdditiveUsingKeyFrames��5      $	��100��5      $��20��6   $��12,0,0,5q�6   ���	#AA3333FF$
��Left=�6B   �� 5      $��0,30,0,0q�6   $
��Left=�6   .��6:   Restart Animations � Triggers 5      :� 5    
    :� RoutedEvent$ Button.Click��6   .[�5!      �� .��5"      �� .��5)      W�  �� 
TargetName$ withIsAdditive��5*       �� TargetProperty$ Width�5+       g� Duration$ 0:0:3D�5,       W� From$	 100X�6"   	 W� To$	 200X�6-    W� 
IsAdditive . 66   W� 50      $ withoutIsAdditive��51      $ Width�52      $ 0:0:3D�53      $	 100X�6"   $	 200X�6-    .  66   U� 58      $" withIsAdditiveUsingKeyFrames��59      $ Width�5:      	 U� 
IsAdditive	 . \�5=      �� 
 O� Value$	
 100Q�6)    O� KeyTime$ 0:0:0��65   �� 5>      $	
 130Q�6)   $ 0:0:1��65   �� 5?       �� 	KeySpline$ 0.6,0.0 0.9,0.00��6)   $	
 200Q�6F   $ 0:0:3��6R   5A      U� 5E      $% withoutIsAdditiveUsingKeyFrames��5F      $ Width�5G      	 .  \�5J      �� $	
 100Q�6)   $ 0:0:0��65   �� 5K      $	
 130Q�6)   $ 0:0:1��65   �� 5L      $ 0.6,0.0 0.9,0.00��6)   $	
 200Q�6F   $ 0:0:3��6R   5N      5P      5R      5S      5U      5V      5W      5X      