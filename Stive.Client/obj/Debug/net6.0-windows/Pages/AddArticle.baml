   M S B A M L   `   `   `  ����G  CStive.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Stive.Client.PagesStive.Client.Pages  5      #    Stive.Client.Pages.AddArticle   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Stive.Client.Pages     5      $	��370��5      $	��356��6     � Title$  Créer un article��5	      .��5      ��  �� Orientation$ Vertical=�6   $��10q�6(   .+�5   
   �� $��Designation��6   6(   �� 5   
   -   5         ��Name$ designation��5      6)   �� 5   
   $��
Catégorie��6   �� 5   
   -   5         ��Name$ catgorySelector��5       $	��120��6    �� DisplayMemberPath$ Label��69    �� SelectedValuePath$ Id��6S   �� 5   
   $��Fournisseur��6   �� 5   
   -   5        $ fournisseurSelector��5      $	��120��6   $	 Nom��6<   $ Id��6T   �� 5   
   $��Description��6   6(   �� 5   
   -   5        $ description��5      6)   �� 5   
   $
��Prix��6   6!   �� 5   
   -   5        $
 prix��5      6"   �� 5   
   $	��TVA��6   6    �� 5   
   -   5        $	 tva��5      6!   �� 5   
   -   5         ��Name$ mediaPicker��5      $��Ajouter une image��6&   6B   �� 5   
   $ 
Horizontal=�6   $��Right=�6.   .+�5      �� -   5        $ 
btnValider��5      $��Valider��6)   $��0,5,0,0q�6;    �� 	IsDefault$
 True��6L   6]   �� 5      -	   5        $ 
btnAnnuler��5      $��Annuler��6)   $��5,5,0,0q�6;    �� IsCancel$
 True��6L   5      5      5      