   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5      !    eStud.ReferentIzmeniPodatke   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������$��533.628��5   2   $��434.956��6C   .��5	      � .+�5   
   �� -   5          ��Name$  	pnlIzmeni��5      $
��Left=�6(   $��513.628��6C   $	��Top=�6T   $	��402��6l   $��	10,10,0,0q�6x   .+�5      �� -   5         ��Name$ txtUsername��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��6+    %  !MaterialDesignFloatingHintTextBox#��[  6t   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6  $��Segoe UI Light)�6   �� 
CaretBrush �	#FF3AB75C��6�   Z� 60  �� 5      -   5        $ txtIme��5      $	 Ime��6&   #��[  6j   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   $��45.44��6   �	#FF3AB75C6  �� 5      -   5        $ 
txtPrezime��5      $ Prezime��6*   #��[  6r   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C6  �� 5      $	��Pol��6    J� IsHitTestVisible .  $��20(�6<   ���	#DD939393$��Segoe UI Light)�6a   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ Hidden=�67    �� Triggers 5      �� 5      	 �� Binding	 6*   �� *SelectedItem+
 �� ElementName$
 txtPol�� �� Value 6_   Z� .a�5   "   ��  � y�$ Visible=�6?   5      5      5      �� 5      -   5         ��Name$ txtPol��5      $
��Left=�6(   $	��Top=�6C   $	��402��6[   $��36��6g   $��20(�6s   ���	#FFF5804B���	#FF727272.@�5      �� $��Zenski��6   $��20(�60   ���	#FF9393936>   �� 5      $��Muski��6   $��20(�6/   ���	#FF8585856=   5       (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ txtDatumRodj��5!      $
��Left=�6/   $	��Top=�6J   $��45��6b   $	��402��6n   $��20(�6z   ���	#FFF5804B���	#FF7272726�   �� 5#      -   5        $ txtDepartman��5#      $ 	Departman��6,   #��[  6v   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6    �	#FF3AB75C6  �� 5$      -   5        $ txtStudijskiProgram��5$      $ Studijski program��63   #��[  6f   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $
��45.6��6�   $��Segoe UI Light)�6�    �	#FF3AB75C6  �� 5%      -	   5        $ txtGrad��5%      $
 Grad��6'   #��[  6l   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $
��45.6��6�   $��Segoe UI Light)�6   �	#FF3AB75C$��	0,0,0.5,0q�67  �� 5&      -
   5        $ 	txtAdresa��5&      $ Adresa��6)   #��[  6p   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $
��45.6��6�   $��Segoe UI Light)�6   �	#FF3AB75C$��	0,0,0.5,0q�6;  �� 5'      -   5         ��Name$ 
btnSacuvaj��5'      $��Sacuvaj��6)   $	��Top=�6;   $��0,20,0,0q�6U   ���	#FFF5804B$��62.593��6�   $
��Left=�6�   $	��402��6�   $��36(�6�   $��Segoe UI Light)�6�   ��6~   Z� 6�   5(      5*      5+      