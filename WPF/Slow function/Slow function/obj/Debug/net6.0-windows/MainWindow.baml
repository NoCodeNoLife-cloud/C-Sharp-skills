   M S B A M L   `   `   `  ����H  DSlow function, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Slow_functionSlow_function  5   	       Slow_function.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Slow_function     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��myRectangle��5
      $	��200��6'   $��30��63   
����  � � Triggers 5      :� 5       :� RoutedEvent$ Rectangle.MouseDown��6   .[�5      �� .��5      �� .��5      �� -   5         ��Name$ myStoryboard��5   )   .��5   "   W�  W� From 3062   	 W� To 2006<    g� Duration$ 00:00:3D�6E    �� 
TargetName$ myRectangle��5       �� TargetProperty$ Height�5      	 W� EasingFunction	 5   &   /  )System.Windows.Media.Animation.BounceEase  5   *   
   Bounces$
 2��65   7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ EaseOut=�6A      
Bounciness$ 2Q�5   "   5   #   5      5      5      5      5      5      5      