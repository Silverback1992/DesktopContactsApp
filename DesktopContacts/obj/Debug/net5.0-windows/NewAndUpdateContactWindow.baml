   M S B A M L   `   `   `  ����J  FDesktopContacts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DesktopContactsDesktopContacts  5   	   /    )DesktopContacts.NewAndUpdateContactWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DesktopContacts     5   	     � Title$  NewContactWindow��5   	   $
��Auto��6"   $
��1000��60    � SizeToContent$ Height=�5	   	    � 
ResizeMode$ CanMinimize=�5
   	   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Name:��6   �� 5   
   -   5         ��Name$ nameTextbox��5      �� 5    
   $��Email:��6   $��1��5!      �� 5"   
   -   5        $ emailTextbox��5"      $��1��5#      �� 5$   
   $��Phone:��6   $��2��5%      �� 5&   
   -   5        $ phoneTextbox��5&      $��2��5'      �� 5(   
   -   5         ��Name$ 
saveButton��5(      $
��Save��5)      $��3��5+      $��6��5,      $��2��5-      �� 5.   
   -   5        $ 
backButton��5.      $
��Back��5/      $��3��51      $��2��52      �� 53   
   -   5        $ updateButton��53      $��Update��54      $��3��56      $��4��57      $��2��58      59      5:      