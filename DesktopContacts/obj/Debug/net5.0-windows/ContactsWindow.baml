   M S B A M L   `   `   `  ����J  FDesktopContacts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DesktopContactsDesktopContacts  5   	   C&clr-namespace:DesktopContacts.ControlsDesktopContacts.Controls  5   	   $    DesktopContacts.ContactsWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DesktopContacts     5   	   5uc&clr-namespace:DesktopContacts.Controls     5   	     � Title$  ContactsWindow��5	   	   $	��450��6    $
��1200��6-    � 
ResizeMode$ CanMinimize=�5
   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��6* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5"   
   �� -   5         ��Name$ searchTextBox��5"      $��0q�5#      $��20(�5$      $��Search for a name here..��5%      $��0��5(      $��5��5)      �� 5+   
   -   5         ��Name$ 
backButton��5+      $��5��5-      $��2��5.         contactsWindowButton#��[  5/      $
��Back��50      �� 52   
   -   5        $ sortAZButton��52      $��7��54      #��[  55      .��56      �� $��Images/AZSort.png��6   57      �� 59   
   -   5        $ sortZAButton��59      $��8��5;      #��[  5<      .��5=      �� $��Images/ZASort.png��6   5>      �� 5@   
   -   5        $ dbRefreshButton��5@      $��9��5B      $��2��5C      #��[  5D      $��
Refresh db��5E      �� 5G   
   -   5        $ updateContactButton��5G      $��11��5I      $��2��5J      
������
�������#��[  5M      $��Update Contact��5N      �� 5P   
   -   5        $ deleteContactButton��5P      $��13��5R      $��2��5S      
���  ��
�������#��[  5V      $��Delete Contact��5W      �� 5Y   
   -   5         ��Name$ contactsListView��5Y      $��1��5Z      $��15��5[      $��0q�5\      ��5]      �� 5^       �� 
TargetType" ��6   .�5_      ��  �� Property � ��	 �� Value$	 Stretch=�6C   5`      ��5b      �� 5c      .R�5d      -   'DesktopContacts.Controls.ContactControl  
   Contact
 6(   �� 5p      5r      5s      5t      