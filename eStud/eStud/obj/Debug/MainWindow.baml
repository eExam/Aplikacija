   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5   	       eStud.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:eStud     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Icon$ Slike/HomeIcon.png��5      $	��890��6"   $
��1383��6/    � 
ResizeMode$ NoResize=�6<    � WindowStyle$ ThreeDBorderWindow=�6R    � WindowStartupLocation$ CenterScreen=�6s   .��5      �� ���	#FF7A7A7A$��1q�6%   $
��Left=�69   $	��861��6T   $	��Top=�6a   $
��1377��6y   ._�5   
   � 
�������.+�5      �� $	��861��6   $��Bottom=�6%   $��
754,0,0,-2q�6@   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ 	#FFcd2e53��6'   � 5      $ 	#FFc32b4e��6'   	 � Offset$	 1Q�69   � 5      $ 	#FFF5804B��6'   $		 0.5Q�69   � 5      $ 	#FFDE524F��6'   $
	 0.22Q�69   � 5      $ 	#FFD43E51��6'   $	 0.102Q�69   � 5      $ 	#FFCF404D��6'   $	 0.875Q�69   � 5      $ 	#FFCF3352��6'   $	 0.035Q�69   5      5"      �� 5#      $	��578��6   $��Bottom=�6%   $��820,0,67,141q�6@   
 �� RadiusX$
 15��6V    �� RadiusY$ 15��6c   ��5$      �� 5%       �� Color$ White��6&    �� Opacity$	 0.2Q�64    J� Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         Color$ 	#FFB4B4B4��6'      	Direction$ 0Q�69      
BlurRadius$ 15Q�6G      RenderingBias$ Quality=�6W   5*      � 5+      $	��261��6   $��Bottom=�6    $��861,0,111,265q�6;   .+�5,      �� $��68,28,10,47q�6   .+�5-      �� -   5         ��Name$ txtUser��5-      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Korisničko ime��6/    % !MaterialDesignFloatingHintTextBox#��[ 6_   $��
10,10,0,10q�6�   $
��Left=�6�   $	��285��6�    �� 
CaretBrush
 ����� �� SelectionBrush
 �����$��25(�6+  ���	#DDFFFFFF���	#89FFFFFF$��Century Gothic)�6h  G� 5.      -   5         G�Name$ txtPass��5.   "    G� PasswordChar$ *��63   $ Lozinka��6p    ) %MaterialDesignFloatingHintPasswordBox#��[ 6�   $��
10,10,0,10q�6�   $
��Left=�6�   $	��285��6   G� 
CaretBrush �	#89FFFFFF G� SelectionBrush
 �����$��25(�6i  $��57��6w  ���	#DDFFFFFF���	#89FFFFFF$��Century Gothic)�6�  �� 5/      -   5         ��Name$ 	lblGreska��5/      $�� ��6/   $
��Left=�6:   $	��Top=�6U   $	��285��6m   $��10,0,0,0q�6y   ���	#DDEE1919$��16(�6�   $��Lucida Calligraphy)�6�   50      �� 51      $��Slike/AccountIcon.png��6   $��
30,0,0,175q�67    J� OpacityMask �	#FFE8E8E8$
��Left=�6c   $��33��6~   $��34��6�   $��Bottom=�6�   �� 52      $��Slike/key.png��6   $��
32,0,0,101q�6/   $
��Left=�6C   $��31��6^   $��32��6i   $��Bottom=�6u    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�53      V� 54      .~�55      �� �� 56       �� AngleY$ -0.682Q�6,   �� 57      T� 58       T� Y$ 0.238Q�61   59      5;      5<      �� 5=      $��Slike/profil.png��6   $��0,220,271,561q�6.   $��Right=�6E   $��92��6a   �� 5>      -   5          ��Name$  btnLogin��5>      $��Log in��6'   $
��Left=�68   $��934,580,0,0q�6S   $	��Top=�6h   $	��284��6�   $��62��6�   ���	#FFDADADA$��25(�6�   $��Century Gothic)�6�   ��6�   Z� 6�   �� 5?      $��PRIJAVA��6   $��Right=�6'   $��Bottom=�6C   $��0,0,205,639q�6^   
�������$��48(�6�   $	��202��6�   $��Century Gothic)�6�   �� 5A      $��Slike/comp.png��6   $��60,239,654,357q�6,   �� 5B      $
��Left=�6   $��
86,544,0,0q�63   $
��Wrap=�6G   $M��GUnesite vaše korisničko ime i lozinku i jednim klikom prijavite ispit��6[   $	��Top=�6�   $	��261��6�   $	��698��6�   $��48(�6�   $��Lucida Calligraphy)�6�   ���	#FFCF33526  �� 5C      $
��Left=�6   $��140,140,0,0q�63   $
��Wrap=�6H   $��Dobrošli na eSTUD ��6\   $	��Top=�6v   $	��197��6�   $	��538��6�   $��48(�6�   $��Lucida Calligraphy)�6�   ���	#FFCF33526�   5F      5G      5H      