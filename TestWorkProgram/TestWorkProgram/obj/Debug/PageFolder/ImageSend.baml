   M S B A M L   `   `   `  ����J  FTestWorkProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TestWorkProgramTestWorkProgram  5          TestWorkProgram.ImageSend   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:TestWorkProgram     5        N� Title$  	ImageSend��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� $��Контакты:��6   $��	20,10,0,0q�6%   $��15(�68   �� 5   
   -   5         ��Name$ userList��5      $��
-30,35,0,0q�5      $��Center=�5      $	��170��5      $��0��5      
������ $	��Top=�5       �� SelectedItem 5      �� *
ChatUser+��5      �� *ContactUsers+��5      �� 5      .R�5      � $��70��6   .+�5      �� -   5        $	��150��5   !   $��70��6P   ���#F5F5F5$��Center=�6t   $��Center=�6�   ._�5      �� $��15(�6B   $��Center=�6Q   $��Center=�6n   ��6(   �� *
Username+6n   5       5!      5"      5$      � 5%   
   -   5         �Name$ chatGrid��5%      $��1��6!   $y�Hidden=�61   .+�5&      �� $��50��6   ���#F5F5F5$��Stretch=�67   $	��Top=�6U   ._�5'      �� -   5         ��Name$ 	nameBlock��5'      $��15(�6R   $��20,0,0,0q�6`   $
��Left=�6r   $��Center=�6�   ��6/   �� *ChatUser.Username+6�   5(      � 5)   
   $��Stretch=�6   $��1��6+   $��	0,50,0,50q�6;    5*      �� 5+      �� 5,      .+�5.      �� -   5        $ toImage��5.      ��6+   �� *	ImageTo+��5/      �� 50      .R�51      �� $��40��6>   ��6$   �� *Buffer+6>   52      54      �� 55      -   5        $ 	fromImage��55      $��1��6-   ��6=   �� *	ImageFrom+��56      �� 57      .R�58      �� $	��100��6>   $��40��6L   ��6$   �� *Buffer+6L   59      5;      5<      �� 5=   
   -   5         ��Name$ 
loadButton��5=      $��50��6&   ���#F5F5F5$��Stretch=�6H   $��Bottom=�6f   ._�5>      �� -   5        $)��#Загрузить картинку��5>      
��� � �$��15(�5@      $y�Visible=�5A      
�������$��35��5C      $	��150��5D       � 	Resources 5F       �� 
TargetType	 �� Property
 �� Value��%^   '��       �� 5G      " ��6    .�5H      �� 	 �@��CornerRadius$
 4��6=   5I      5J      6*   5K      �� 5L      -	   5        $ nameFile��5L      $y�Hidden=�6*   $��Bottom=�6>   $��	20,0,0,15q�6Y   $
��Left=�6m   $��15(�6�   �� 5M      -
   5         ��Name$ 
sendButton��5M      $y�Visible=�6)   $��Отправить��6>   
��� � �$��15(�5O      
�������$��35��5P   (   $	��110��5Q      $��Right=�5R      $��0,0,10,8q�5S      $��Bottom=�5U      ��5T      �� *
AddCommand+ 5V      ��%^   '��       �� 5W      " ��6   .�5X      �� 	 �@��CornerRadius$
 4��69   5Y      5Z      5[      5\      5]      5^      