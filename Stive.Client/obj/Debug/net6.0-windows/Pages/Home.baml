   M S B A M L   `   `   `  ����G  CStive.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Stive.Client.PagesStive.Client.Pages  5   	       Stive.Client.Pages.Home   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Stive.Client.Pages     5   	     � Title$
  Home��5   	   $	��450��6   $	��800��6#   .��5
      � .+�5   
   �� .@�5      �� $��Articles��6   .��5      � .+�5      �� -   5         ��Name$ btn_new_article��5      $��Nouveau��66   $
��Left=�6H   $��
10,147,0,0q�6c   $	��Top=�6w   $��28��6�   $��65��6�   6�   �� 5      -   5        $ btn_edit_article��5      $��Modifier��67   $
��Left=�6J   $��
88,147,0,0q�6e   $	��Top=�6y   $��28��6�   $��65��6�   �� 5      -   5        $ btn_del_article��5      $��	Supprimer��67   $
��Left=�6K   $��166,147,0,0q�6f   $	��Top=�6{   $��28��6�   $��65��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ articlesList��5      $��	0,180,0,0q�65   $��2��6H   5      5      �� 5      $��Stocks��6   .��5      �  � ColumnDefinitions 5      �� 5      $
��143* �6+   �� 5      $
��254* �6+   .+�5        -   5        $ 	stockList��5      $��	0,180,0,0q�62   $��2��6E   �� 5      $��Nouveau��6   $
��Left=�6/   $��	18,20,0,0q�6J   $	��Top=�6]   $��55��6u   $��55��6�   �� 5      $��Modifier��6   $
��Left=�60   $��	97,20,0,0q�6K   $	��Top=�6^   $��55��6v   $��55��6�   �� 5      $��	Supprimer��6   $
��Left=�61   $��
179,20,0,0q�6L   $	��Top=�6`   $��55��6x   $��55��6�   5       5!      �� 5"      $��
Inventaire��6   .��5#      � .+�5$        -   5        $ inventaireList��5$      $��	0,180,0,0q�67   5%      5&      �� 5'      $��Clients��6   .��5(      � .+�5)        -   5        $ 
clientList��5)      $��	0,180,0,0q�63   �� 5*      $��Nouveau��6   $
��Left=�6/   $��	18,20,0,0q�6J   $	��Top=�6]   $��55��6u   $��55��6�   �� 5+      $��Modifier��6   $
��Left=�60   $��	97,20,0,0q�6K   $	��Top=�6^   $��55��6v   $��55��6�   �� 5,      $��	Supprimer��6   $
��Left=�61   $��
179,20,0,0q�6L   $	��Top=�6`   $��55��6x   $��55��6�   5-      5.      �� 5/      $��Fournisseurs��6   .��50      � .+�51        -   5        $ fournisseursList��51      $��	0,180,0,0q�69   52      53      �� 54      $��	Commandes��6   .��55      � .+�56        -	   5        $ cmdList��56      $��	0,180,0,0q�60   57      58      59      5:      5;      