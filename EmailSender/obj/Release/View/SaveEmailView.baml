   M S B A M L   `   `   `  ���� F  BEmailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EmailSender.ValidationEmailSender.Validation  $    EmailSender.View.SaveEmailView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2v$clr-namespace:EmailSender.Validation     0ignorehttp://www.galasoft.ch/ignore       � DataContext  �� *Main+   Locator �� Source# [  .��� $��0 50 0 0q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��20 ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $
��Auto �.+��� $
��Wrap=�$	��Id:���� $��1��$
��Wrap=�$��Email:���� $��2��$
��Wrap=�$��Name:���� -   $��1�� �� TextWrapping$
 Wrap=�.������  �� Path$ EmailInfo.Id� �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 	 �� ValidatesOnDataErrors	 . 
 �� ValidationRules
 (  "EmailSender.Validation.IdValidator  .���� $��1��$��1��$
 Wrap=����� *EmailInfo.EmailCol+$ TwoWay=�	 . �� $��1��$��2��$
 Wrap=����� *EmailInfo.Name+$ TwoWay=��� $
��Save��$
��Bold"�$��5��$��2��$��22��$	��140������ *SaveCommand+���� *	EmailInfo+