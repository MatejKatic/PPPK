   M S B A M L   `   `   `  ����B  >Zadatak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Zadatak.ViewModelsZadatak.ViewModels  5      !clr-namespace:ZadatakZadatak  5          Zadatak.ListPeoplePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      6	viewmodel clr-namespace:Zadatak.ViewModels     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Zadatak     5        N� Title$  ListPersonsPage��5      .��5      �    GradientBackground#��[  6   .+�5   
   �� -   5        $��LvUsers��5      $��28,54,26,69q�5       �� AlternationCount$ 2��5      ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        �� 5       �� Property � �� �� Value
 ��ح�5       �� Triggers 5      P� 5       P� Property �@��AlternationIndex P� Value$ 1��5   "   . �5      ��  � ��
 �����5   %   5      ]� 5       ]� 
Conditions 5      �� 5    "   	 �� Property	 �@��
IsSelected
 �� Value
 . 5!   ,   ./�5#      ��  � ��
 ���_�5$   %   5%      5'       �� View 5)      �� 5*      .P�5+      ��  �� Width$	 126��6%   $��	FirstName��5,   %    �� DisplayMemberBinding 5-   %   �� *	FirstName+�� 5.      $	 126��6%   $��LastName��5/   %    50   %   �� *
LastName+�� 51      $	 126��6%   $��	Zanimanje��52   %    53   %   �� *zanimanjeOsobe.Naziv+�� 54      $	 126��6%   $	��Age��55   %    56   %   �� *Age+�� 57      $	 126��6%   $��Email��58   %    �� CellTemplate 59      �� 5:      .R�5;   "   �� $��	Underline{�5<   ,   
���   � � Cursor$
 Hand��5>   ,   ��5;   ,   �� *Email+ � ToolTip 5?   &   �� 5@   *    ��Name$ Picture��60   $��60��5B   0   $��60��5C   0   $��0,0,5,0q�5D   0   ��5A   0   �� *Image+5D   0   5F   #   5G      5I      5J      5L      �� 5N   
   -   5         ��Name$ BtnEdit��5N      $
��Edit��5O      $
��Left=�5P      $	��Top=�5Q      $��75��5R      
����������#13242C J� RenderTransformOrigin$ 1.101,3.807&�5V      $��585,391,0,0q�5W      �� 5Z   
   -   5        $ 	BtnDelete��5Z      $��Delete��5[      $
��Left=�5\      $	��Top=�5]      $��75��5^      
����������	#FFD41B43$ 1.101,3.807&�5b      $��684,391,0,0q�5c      �� 5e   
   -   5        $ BtnAdd��5e      $	��Add��5f      $
��Left=�5g      $	��Top=�5h      $��75��5i      
����������	#FF246844$ 1.101,3.807&�5m      $��491,391,0,0q�5n      �� 5o   
   -   5        $ BtnZanimanja��5o      $��Popis Zanimanja Osoba��5p      $
��Left=�5q      $	��Top=�5r      $	��143��5s      
�������
����  �$ 1.101,3.807&�5w      $��323,391,0,0q�5x      5y      5z      