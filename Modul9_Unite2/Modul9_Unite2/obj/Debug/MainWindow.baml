   M S B A M L   `   `   `  ����  Modul9_Unite2    UyeKayit.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Üye Kayıt��5   	   $	��200��6   $	��300��6(    � 	Resources 5       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%  '��       �� 5   
   " ��6    5	      P� 5
       �@=�HasError . . �5      ��  �@�ToolTip 5      ��  �� *Self+$)	 #(Validation.Errors)[0].ErrorContent��� 5       � ��
 �  ��64   �� 5       � ��$ 2q�68   5      5      5      .��5      � $��10q�6   
 � RowDefinitions
 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� .+�5      �� $	��Ad:��6   �� 5      $	��200��6   $��0,5,0,10q�6"   ��5      �� *Ad+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5       $��Mail:��6   �� 5!      $	��200��6   $��0,5,0,10q�6"   ��5"      �� *Mail+$ PropertyChanged=� . 5#      5$      5%      