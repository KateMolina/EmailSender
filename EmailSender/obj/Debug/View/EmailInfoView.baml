   M S B A M L   `   `   `  ����  EmailSender$    EmailSender.View.EmailInfoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5      "ignorehttp://www.ignore.com  5      $
��Auto��5   	   $
��Auto��6     � DataContext  5
      �� *Main+   Locator �� Source# [  .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .  (System.Windows.Interactivity.Interaction   Triggers 5   
   /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     Command 6&   �� *ReadAllCommand+5      .+�5   
   �� $
��Wrap=�6    �� TextAlignment$ Center=�5      $��Email Recipients��6+   $
��Bold"�6C   �� 5   
   -   5         ��Name$ btnLoadAllEmails��5      $��	Show Data��6+   $��3��5      $
��Bold"�6   $	��140��60   ��6<   �� *ReadAllCommand+&   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgEmails��5      $��2��6%   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 5       $��	0,10,0,28q�6#    J� RenderTransformOrigin$ 0.5,0.5&�66      
IsReadOnly .  �� SelectedItem 5   2   �� *	EmailInfo+��6U   �� *
EmailsView+5!      �� 5"   
   $
��Left=�6   $��10,7,0,0q�6/   $��1��6A   $
��Wrap=�6N   $��Search by Name:��6b   $	��Top=�6y   $	��231��6�   �� 5#   
   $
��Left=�6   $��30��6-   $��	267,7,0,0q�69   $��1��6L    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6�   $	��310��6�   ��6m   �� *
FilterName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Delay$	 100��6�   5$      5%      