   M S B A M L   `   `   `  ����F  BEmailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EmailSender.ValidationEmailSender.Validation  5      $    EmailSender.View.SaveEmailView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2v$clr-namespace:EmailSender.Validation     5      0ignorehttp://www.galasoft.ch/ignore     5   	     � DataContext  5	      �� *Main+   Locator �� Source# [  .��5
      � $��0 50 0 0q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $
��Wrap=�6   $	��Id:��6(   �� 5   
   $��1��6   $
��Wrap=�6!   $��Email:��65   �� 5   
   $��2��6   $
��Wrap=�6!   $��Name:��65   �� 5   
   -   5        $��1��5       �� TextWrapping$
 Wrap=�6"   .��6W   ��5      �� 5       �� Path$ EmailInfo.Id�6    �� Mode$ TwoWay=�6.    �� NotifyOnValidationError .  �� ValidatesOnExceptions . 	 �� ValidatesOnDataErrors	 . 
 �� ValidationRules
 5      (  "EmailSender.Validation.IdValidator  5      5      .��5       5!      �� 5"   
   $��1��6   $��1��6"   $
 Wrap=�6/   ��6C   �� *EmailInfo.EmailCol+$ TwoWay=�	 . �� 5#   
   $��1��6   $��2��6"   $
 Wrap=�6/   ��6C   �� *EmailInfo.Name+$ TwoWay=��� 5$   
   $
��Save��6   $
��Bold"�6    $��5��62   $��2��6?   $��22��6�   $	��140��6�   ��6S   �� *SaveCommand+��6s   �� *	EmailInfo+6�   5%      5&      