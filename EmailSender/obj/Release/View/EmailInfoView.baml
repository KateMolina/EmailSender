   M S B A M L   `   `   `  ����   EmailSender$    EmailSender.View.EmailInfoView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  "ignorehttp://www.ignore.com  $
��Auto��$
��Auto��  � DataContext  �� *Main+   Locator �� Source# [  .���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. /  )GalaSoft.MvvmLight.Command.EventToCommand     Command �� *ReadAllCommand+.+��� $
��Wrap=� �� TextAlignment$ Center=�$��Email Recipients��$
��Bold"��� -    ��Name$ btnLoadAllEmails��$��	Show Data��$��3��$
��Bold"�$	��140������ *ReadAllCommand+&   System.Windows.Controls.DataGrid  -   	  Name$	 dgEmails��$��2��
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * $��	0,10,0,28q� J� RenderTransformOrigin$ 0.5,0.5&�   
IsReadOnly .  �� SelectedItem �� *	EmailInfo+���� *
EmailsView+�� $
��Left=�$��10,7,0,0q�$��1��$
��Wrap=�$��Search by Name:��$	��Top=�$	��231���� $
��Left=�$��30��$��	267,7,0,0q�$��1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��310������ *
FilterName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Delay$	 100��