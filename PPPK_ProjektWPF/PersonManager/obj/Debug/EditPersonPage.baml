   M S B A M L   `   `   `  ����B  >Zadatak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ZadatakZadatak  5      7 clr-namespace:Zadatak.ViewModelsZadatak.ViewModels  5          Zadatak.EditPersonPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Zadatak     5      6	viewmodel clr-namespace:Zadatak.ViewModels     5        N� Title$  EditPage��5      .��5      � -   5         �Name$ GridContainter��5         GradientBackground#��[  5      .+�5   
   �� -   5         ��Name$ BtnBack��5      
������ 
������ $
��Left=�5      $	��Top=�5      $��25��5      $��25��5      $��30q�5      .��5      �� $��/Assets/back.png��6   5      �� 5   
   $��First name:��6   $
��Left=�5      $��	57,89,0,0q�5      $	��Top=�5      ���	#FFF6F9FE5       �� 5"   
   -   5         ��Name$ TbFirstName��5"      $
��Left=�5#      $��23��5$      $��
134,88,0,0q�5%       �� TextWrapping$
 Wrap=�5&      $	��Top=�5(      $	��171��5)      ��5'      �� *person.FirstName+5)      �� 5+   
   $��
Last Name:��6   $
��Left=�5,      $��
57,133,0,0q�5-      $	��Top=�5.      ���	#FFF6F9FE5/      �� 51   
   -   5        $ 
TbLastName��51      $
��Left=�52      $��23��53      $��134,134,0,0q�54      $
 Wrap=�55      $	��Top=�57      $	��171��58      ��56      �� *person.LastName+58      �� 5:   
   $	��Age��6   $
��Left=�5;      $��
57,187,0,0q�5<      $	��Top=�5=      ���	#FFF6F9FE5>      �� 5@   
   -   5        $ TbAge��5@      $
��Left=�5A      $��23��5B      $��267,187,0,0q�5C      $
 Wrap=�5D      $	��Top=�5F      $��38��5G      
 � Tag$	 Int��5H      ��5E      �� *
person.Age+5H      �� 5K   
   $��Email��6   $
��Left=�5L      $��
57,236,0,0q�5M      $	��Top=�5N      ���	#FFF6F9FE5O      �� 5Q   
   -   5        $ TbEmail��5Q      $
��Left=�5R      $��23��5S      $��134,236,0,0q�5T      $
 Wrap=�5U      $	��Top=�5W      $	��171��5X      $ Email��5Y      ��5V      �� *person.Email+5Y      �� 5^   
   -   5        $ 	BtnCommit��5^      $��Commit��5_      $
��Left=�5`      $	��Top=�5a      $��75��5b      
����������#13242C$��
86,322,0,0q�5f      �� 5h   
   -   5        $ 	BtnUpload��5h      $��Upload Image��5i      $
��Left=�5j      $	��Top=�5k      $	��106��5l      
�������
��� ���$��199,322,0,0q�5p      �� 5r   
   -	   5         ��Name$ PictureBorder��5r      
�������$	��0.3q�5t      $��Right=�5u      $	��Top=�5v      $��	0,79,48,0q�5w      ._�5x      �� -
   5         ��Name$ Picture��5x      $��Uniform=�5y      $	��198��5z      $	��252��5{      ��5|      �� *person.Image+5}      �� 5~   
   -   5        $��
Zanimanje:��5~      $
��Left=�5      $��
58,278,0,0q�5�      $	��Top=�5�      ���	#FFF6F9FE5�      �� 5�   
   -   5         ��Name$ cbKlub��5�      $
��Left=�5�      $	��Top=�5�      $	��120��5�      $��134,278,0,0q�5�      ��5�      �� *zanimanja.popisZanimanja+	 �� SelectedItem	 5�      �� *zanimanja.zanimanjeOsobe+5�      5�      5�      