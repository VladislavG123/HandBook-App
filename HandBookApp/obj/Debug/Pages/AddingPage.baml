   M S B A M L   `   `   `  ����F  BHandBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HandBookApp.PagesHandBookApp.Pages  5      "    HandBookApp.Pages.AddingPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HandBookApp.Pages     5        N� Title$  
AddingPage��5	       N� 
Background 5
      �� 5   
    �� Color$ Black��6    �� Opacity$ 0Q�6(   .��5      � $	��440��6   $	��300��6   
�������.+�5   
   �� $��0                    ��6   $��Center=�5      $	��250��63   $��
43,34,48,0q�6@   
�������$	��Top=�6c   $	��209��6{    �� StrokeStartLineCap$ Round=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         	Direction$	 275Q�6#      Color$ 	#FFE9F0FF��63   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FF1152A0��6#    � Offset$ 0Q�65   � 5      $
 	#FF3186EC��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$ CitiesComboBox��5      $
��Left=�6+   $��	90,81,0,0q�6F   $	��Top=�6Y   $	��120��6q   �� 5   
   -   5         ��Name$ PhoneTextBox��5       �� 	MaxLength$ 7��6(   $
��Left=�66   $��24��6Q   $��
90,142,0,0q�6]    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $ NameTextBox��5      $ 16��6'   $
��Left=�66   $��23��6Q   $��
90,205,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��120��6�   �� 5   
   $!��Выберите город��6   $
��Left=�6)   $��	55,55,0,0q�6D   $	��Top=�6W   
�������6o   �� 5    
   $0��*Введите номер телефона��6   $
��Left=�61   $��
55,116,0,0q�6L   $	��Top=�6`   
�������6x   �� 5!   
   $,��&Введите имя абонента��6   $
��Left=�6/   $��
55,179,0,0q�6J   $	��Top=�6^   
�������6v   �� 5"   
   -   5        $��ДОБАВИТЬ��5"      $
��Left=�6$   $��
90,261,0,0q�6?   $	��Top=�6S   $	��105��6k   $��35��6w   ��5#      
� 5$      .��5%      � $
 White��6#   $ 0Q�61   � 5&      $
 	#FFE6E8EE��6#   $ 1Q�65   5'      5)      �� 5*   
   $
��Left=�6   $��22��6+   $��
222,81,0,0q�67   $	��Top=�6K   $��18��6c    J� OpacityMask 5+      �� 5,       �� ImageSource$, &/HandBookApp;component/Icons/close.png��6   5.      51      52      