   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5          eStud.StudentIzmeniPodaci   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������$	��703��5   2   $	��607��6>   .��5	      � $��0,0,0,10q�6   .+�5   
   �� $
��Left=�6   $��334.77��60   $��10,8.885,0,0q�6@   $	��Top=�6V   $��223.5��6n   .+�5      �� -   5          ��Name$  txtUsername��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��6+    %  !MaterialDesignFloatingHintTextBox#��[  6t   ���	#FFF5804B���	#DD575757$
��Bold"�6�   $��18(�6  $��Segoe UI Light)�6   �� 
CaretBrush �	#FF3AB75C$��45��6G  ��6�   Z� 6G  �� 5      -   5        $  txtIme��5      $	 Ime��6&   #��[  6j   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   $��45��6   �	#FF3AB75C6  �� 5      -   5        $  
txtPrezime��5      $ Prezime��6*   #��[  6r   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��45��6/  �� 5      $	��Pol��6    J� IsHitTestVisible .  $��20(�6<   ���	#DD939393$��Segoe UI Light)�6a   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ Hidden=�67    �� Triggers 5      �� 5       �� Binding 6*   �� *SelectedItem+	 �� ElementName$	 txtPol��
 �� Value
 6_   Z� .a�5   "   ��  � y�$ Visible=�6?   5      5      5      �� 5      -   5         ��Name$ txtPol��5      $
��Left=�6'   $	��Top=�6B   $	��224��6Z   $��36��6f   $��20(�6r   ���	#FFF5804B.@�5      �� $��Zenski��6   �� 5      $��Muski��6   5      (  "System.Windows.Controls.DatePicker  5      -   5          Name$ txtDatumRodj��5      $
��Left=�6/   $	��Top=�6J   $��45��6b   $	��224��6n   ���	#FF7C7C7C���	#FFF5804B6�   �� 5!      -   5        $  txtGrad��5!      $
 Grad��6'   #��[  6l   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��45��6�   $��Segoe UI Light)�6   �	#FF3AB75C6  �� 5"      -   5        $  	txtAdresa��5"      $ Adresa��6)   #��[  6p   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��45��6-  5#      �� 5$   
   -   5         ��Name$ 
btnSacuvaj��5$      $��Sacuvaj��6>   $
��Left=�6P   $��10,529.726,0,0q�6k   $	��Top=�6�   $��471.5��6�   $��57.274��6�   ���	#FFF5804B$��36(�6�   ���	#DDFFFFFF$��Segoe UI Light)�6  ��6�   Z� 6  �� 5%   
   $
��Left=�6   $��334.77��60   $��264.5,8.885,0,0q�6@   $	��Top=�6Y   $	��229��6q   .+�5&      �� -	   5        $  txtDepartman��5&      $ 	Departman��6,   #��[  6v   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6    �	#FF3AB75C$��44��63  �� 5'      -
   5        $  txtStudijskiProgram��5'      $ Studijski program��63   #��[  6�   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6  $��Segoe UI Light)�6   �	#FF3AB75C$��0,0,-0.984,0q�6B   J� RenderTransformOrigin$ 0.5,0.5&�6X  $��45��6x  �� 5)      -   5        $  txtSemestar��5)      $ Semestar��6+   #��[  6V   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��45��6  �� 5*      $��Status��6    .  $��20(�6?   ���	#DD939393$��Center=�6d   $��0,0,85,0q�6�   $	��144��6�   $ -0.004,-1.154&�6�   $��27��6�   $��Segoe UI Light)�6�   ��5+      �� 5,      " ��6   .�5-      ��  � y�$ Hidden=�67    5.      �� 5/       6*   �� *SelectedItem+$	 	txtStatus��
 6b   Z� .a�50   "   ��  � y�$ Visible=�6?   51      53      55      �� 56      -   5        $ 	txtStatus��56      $
��Left=�6*   $	��Top=�6E   $	��229��6]   $��36��6i   $��20(�6u   ���	#FFF5804B.@�57      �� $��20(�6   .��6-   Budzet65   �� 58      $��20(�6   .��6-   Samofinansiranje6?   59      �� 5:      -   5        $  txtBrojIndeksa��5:      $ Broj indeksa��6.   #��[  6\   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��44��6  �� 5;      -   5        $  txtGodinaUpisa��5;      $ Datum Upisa��6.   #��[  6[   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��45��6  5<      5>      5?      