   M S B A M L   `   `   `  ����B  >Zadatak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ZadatakZadatak  5      7 clr-namespace:Zadatak.ViewModelsZadatak.ViewModels  6+       Zadatak.ListZanimanjaPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Zadatak     5      6	viewmodel clr-namespace:Zadatak.ViewModels     6+     N� Title$  ListZanimanjaPage��5
      .��5      �    GradientBackground#��[  6   .+�5   
   �� -   5         ��Name$ BtnBack��5      
������ 
������ $
��Left=�5      $	��Top=�5      $��25��5      $��25��5      $��30q�5      .��5      �� $��/Assets/back.png��6    J� RenderTransformOrigin$ 
0.59,0.019&�6.   5      �� 5   
   -   5        $��LvZanimanja��5      $��28,54,26,69q�5       �� AlternationCount$ 2��5      ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        �� 5        �� Property � �� �� Value
 ��ح�5!       �� Triggers 5"      P� 5#       P� Property �@��AlternationIndex	 P� Value$	 1��5$   "   . �5%      ��  � ��
 �����5&   %   5'      ]� 5(      
 ]� 
Conditions
 5)      �� 5*   "    �� Property �@��
IsSelected �� Value . 5+   ,   ./�5-      ��  � ��
 ���_�5.   %   5/      51       �� View 53      �� 54      .P�55      ��  �� Width$	 541��6%   $��Popis svih zanimanja��56   %    �� DisplayMemberBinding 57   %   �� *Naziv+58      5:      �� 5<   
   -   5        $ BtnEdit��5<      $
��Edit��5=      $
��Left=�5>      $	��Top=�5?      $��75��5@      
����������#13242C$ 1.101,3.807&�5D      $��361,406,0,0q�5E      �� 5F   
   -   5        $ 	BtnDelete��5F      $��Delete��5G      $
��Left=�5H      $	��Top=�5I      $��75��5J      
����������	#FFD41B43$ 1.101,3.807&�5N      $��458,406,0,0q�5O      �� 5P   
   -   5        $ BtnAdd��5P      $	��Add��5Q      $
��Left=�5R      $	��Top=�5S      $��75��5T      
����������	#FF246844$ 1.101,3.807&�5X      $��261,406,0,0q�5Y      5[      5\      