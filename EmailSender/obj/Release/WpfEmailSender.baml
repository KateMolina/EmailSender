   M S B A M L   `   `   `  ���� F  BEmailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EmailSenderEmailSender  3clr-namespace:EmailSender.ViewEmailSender.View  F BTabSwitcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:TabSwitcher;assembly=TabSwitcherTabSwitcher     EmailSender.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     X TXceed.Wpf.Toolkit, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  %localclr-namespace:EmailSender  )Viewclr-namespace:EmailSender.View  @TabSwitcher.clr-namespace:TabSwitcher;assembly=TabSwitcher    � Title$  EmailSender��$	��450��$	��800��.��]� .+�o� $��25��$	��Top=�$	��Top=�.@�m� $
��File��.@�m� -    m�Name$ miClose��$
��Exit���� -    ��Name$ 
tabControl��$	��Top=�$	��Top=�$��0,0,0.333,0q�$	��393��.@��� -    ��Name$ 	DistroTab��$��Distribution��.��]� .+�`� $	��Top=�$��65��.�c� -    c�Name$ tbSender��$
��Left=�$��30��$	��Top=�$	��500��.@��� -    ��Name$ LSender��$��Sender��$��25��$	��Top=�$	��130���� -    ��Name$ btnAddSender�� � ToolTip$ 
Add Sender��$��Stretch=�$��25��$��25��.���� $��Images/add.png��$��15��$��2q��� -   $ btnEditSender��$ Edit Sender��$��Stretch=�$��25��$��25��.���� $��Images/Edit.png��$��15���� -   $ btnDeleteSender��$ Delete Sender��$��Stretch=�$��25��$��25��.���� $��Images/delete.png���� -	    ��Name$ cbSenderSelect��$��25��$��0q�$	��Top=�$	��270��$ Select email address��c� -
   $ tbSmtp��$
��Left=�$��30��$	��Top=�	 c� Band$	 1��
 c� 	BandIndex$
 0��$��0,0,-477.667,0q�$	��500��.@��� -   $ lSmtp��$��Select Smtp-Server��$��25��$	��Top=�$	��130���� -   $ 
btnAddSmtp��$ Add Smtp��$��Stretch=�$��25��$��25��.���� $��Images/add.png��$��15���� -   $ btnEditSmtp��$ 	Edit Smtp��$��Stretch=�$��25��$��25��.���� $��Images/Edit.png��$��15���� -   $ btnDeleteSmtp��$ Delete Smtp��$��Stretch=�$��25��$��25��.���� $��Images/delete.png���� -   $ cbSmtpSelect��$��25��$��0q�$	��Top=�$	��270�� �� SelectedIndex$ 0��$ Select Smtp-Server��c� -   $ 	tbPlanner��$
��Left=�$��30��$	��Top=�$	��230��$	 0��$
 1��.@��� -   $ lPlanner��$��Go to Planner��$��25��$
��Auto���� -   $ btnClock��$��25��$��25��$ Go to Planner��.���� $��Images/clock.png��c� -   $ 
tbAddresee��$��Right=�$��30��$��Bottom=�$	��230��$	 1��$
 1��$��0,0,-708,-5q�.@��� -   $ 	lAddresee��$��Addresee List��$��25��$
��Auto��$	��Top=��� -   $ btnAddAddresee��$ Add Addresee��$��Stretch=�$��25��$��25��.���� $��Images/add.png��$��15���� -   $ btnEditAddresee��$ Edit Addresee��$��Stretch=�$��25��$��25��.���� $��Images/Edit.png��$��15���� -   $ btnDeleteAddresee��$ Delete Addresee��$��Stretch=�$��25��$��25��.���� $��Images/delete.png��� ���	#FFE5E5E5 � RowDefinitions �� $��60 ��� $
��Auto � � ColumnDefinitions �� $	��20* ��� $	��73* �.+�`� $��Stretch=�$��Stretch=�$
��Auto��$��2��$
��Auto��$��0,0,0.333,130q�$��2��$   EmailSender.View.EmailInfoView  -     Name$ 	emailInfo��$��Stretch=�$
��Left=�$��169,3,0,-167.333q�$	��618�� J� RenderTransformOrigin$ 0.502,0.581&�$��2��$��2��$   EmailSender.View.SaveEmailView  -     Name$ 	saveEmail��$��Stretch=�$��Center=�$��1��$��0,0,0.333,-167.333q�$	��169��$��2���� -   $ 
tabPlanner��$��Planner��.��� .+��� .+�&   System.Windows.Controls.Calendar  -     Name$ cldScheduleDateTimes��   SelectionMode$ MultipleRange=�$
��Left=�$��0,20,0,0q��� -   $ btnSchedule��$��20��$	��179��$
��Left=�.����  �� Orientation$ 
Horizontal=�.+��� $��Images/clock.png��$��0,0,5,0q��� $��Schedule���� -   $ 
SendAtOnce��$��Send At Once��$��20��$	��179��$
��Left=��� -    ��Name$ plannerListView��$	��100��$��0,0,274.333,0q� �� View �� .P��� .@��� -   $ btnAddShedControl��$	��491��.���� $ 
Horizontal=�.+��� $��Images/mailPlus.png��$��15��$��2q��� $�� Add a Message���� -    $ 	EditorTab��$��Editor��.��� ���	#FFE5E5E5 �� $	��94* ��� $��8* ��� $
��685* �.+��� -!    ��Name$	 rtb��$��3��$��0,0,-0.667,-0.667q��� -"   $ Statist��$��
Statistics��.��� ���	#FFE5E5E5 �� $	��28* ��� $
��759* �