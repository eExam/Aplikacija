   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5          eStud.DodajStudenta   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ���	#FFD1D1D1$��922.571��5   6   $��703.227��6F   .��5	      � 
�������$��0,0,0,-28.5q�6   .+�5   
   �� $
��Left=�6   $��417.5��60   $��35.5,10,0,0q�6?   $	��Top=�6T   $��369.5��6l   .+�5      �� -   5          ��Name$  txtUsername��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Korisničko ime��6+    %  !MaterialDesignFloatingHintTextBox#��[  6z   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6  $��Segoe UI Light)�6   �� 
CaretBrush �	#FF3AB75C��6�   Z� 66  �� 5      -   5        $  txtPassword��5      $ Lozinka��6+   #��[  6s   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C6  �� 5      -   5        $  txtUsertype��5      $ Tip korisnika��6+   #��[  6Z   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   $��Student��6   {�.   �	#FF3AB75C6!  �� 5      -   5        $  txtIme��5      $	 Ime��6&   #��[  6j   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   $��45.44��6   �	#FF3AB75C6  �� 5      $	��Pol��6    J� IsHitTestVisible .  $��20(�6<   ���	#DD939393$��Segoe UI Light)�6a   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ Hidden=�67    �� Triggers 5      �� 5       �� Binding 6*   �� *SelectedItem+	 �� ElementName$	 txtPol��
 �� Value
 6_   Z� .a�5   "   ��  � y�$ Visible=�6?   5      5      5      �� 5      -   5         ��Name$ txtPol��5      $��Stretch=�6'   $��39��6C   $��20(�6O   ���	#FFF5804B.@�5      �� $��Zenski��6   $��20(�60   ���	#FF8D8D8D6>   �� 5      $��Muski��6   $��20(�6/   ���	#FF9191916=   5       �� 5"      -   5        $  
txtPrezime��5"      $ Prezime��6*   #��[  6r   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C6  (  "System.Windows.Controls.DatePicker  5#      -   5          Name$ txtDatumRodj��5#      $
��Left=�6O   $	��Top=�6j   $��45��6�   $	��370��6�   ���	#FF7C7C7C���	#FFF5804B6�   �� 5%      -   5        $  txtGrad��5%      $
 Grad��6'   #��[  6l   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $
��45.6��6�   $��Segoe UI Light)�6   �	#FF3AB75C6   5&      �� 5'   
   -	   5         ��Name$ 
txtSacuvaj��5'      $��Sacuvaj��6%   $
��Left=�67   $	��Top=�6R   $��743.207��6j   $��35.5,551,0,0q�6�   ���	#FFF5804B$
��66.5��6�   $��36(�6�   $��Century Gothic)�6�   ��6�   Z� 6�   �� 5(   
   -
   5        $  txtDepartman��5(      $ 	Departman��6(   #��[  6r   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��424,58,143.864,628.787q�6/  �� 5)   
   -   5        $  txtStudijskiProgram��5)      $ Studijski program��6/   #��[  6�   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6   �	#FF3AB75C$ ��424,102.94,143.864,585.187q�6>  �� 5*   
   -   5        $  txtSemestar��5*      $ Semestar��6G   #��[  6r   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��425,304,142,381.5q�6/  �� 5+   
   -   5        $  txtBrojIndeksa��5+      $ Broj indeksa��6J   #��[  6x   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6   �	#FF3AB75C$ ��424,146.54,143.864,540.087q�65  �� 5,   
   -   5        $  txtGodinaUpisa��5,      $ Godina Upisa��6K   #��[  6y   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6   �	#FF3AB75C$��426,256,141,427.5q�66  �� 5-   
   -   5        $  	txtAdresa��5-      $ Adresa��6%   #��[  6l   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C$��424,10,142.571,676.127q�6)  �� 5.   
   $��Status��6    .  $��20(�6;   ���	#DD939393$��Center=�6`   $��426,192,353,512.5q�6}   $	��144��6�    J� RenderTransformOrigin$ -0.004,-1.154&�6�   $��Segoe UI Light)�6�   ��5/      �� 50      " ��6   .�51      ��  � y�$ Hidden=�63    52      �� 53       6&   �� *SelectedItem+$	 	txtStatus��
 6^   Z� .a�54      ��  � y�$ Visible=�6;   55      57      59      �� 5:   
   -   5        $ 	txtStatus��5:      $
��Left=�6&   $��425,220,0,0q�6A   $	��Top=�6V   $	��355��6n   $��36��6z   ���	#FFF5804B.@�5;      �� .��6   Budzet6#   �� 5<      .��6   Samofinansiranje6-   5=      5?      5@      