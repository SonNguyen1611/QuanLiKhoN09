   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   F BQuanLyKhoPJ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuanLyKhoPJQuanLyKhoPJ 5   	      QuanLyKhoPJ.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:QuanLyKhoPJ  5   	     � Icon$G  AC:\Users\Son\source\repos\QuanLyKhoPJ\QuanLyKhoPJ\Icon\forest.png��5   	    � Title$
 Home��5   	   $	��550��6   $
��1000��6#   .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  .��5      �� -   5         ��Name$ 
TabControl��5      $��Bottom=�5      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ 
PrimaryMid=�5       *  &MaterialDesignNavigationRailTabControl#��[  5      .@�5      ��  
 HomeVM � DataContext# [ 6   ��5      �� 5      $
��auto��6%   $
��auto��62   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��24��66   $��24��6A   $��Center=�6M      Kind$
 Home=�6j   �� 5      $��Center=�6(   $
��Home��6E   5      .��5      �  � RowDefinitions 5      �� 5      $
��auto �6,   6<   �� 5       6.   .+�5$      � $��0��6   .+�5%        $��5q�62   .��5&   "   � $��0��6'    5'   &   �� 5(   *   $
��auto �68   6H   .+�5*   &   � $��0��6+    � ColumnDefinitions 5+   *   �� 5,   .   $
��auto �6?   6N   �� 5-   .   $
��auto �6?   6N   �� 5.   .   $
��auto �6?   6N   �� 5/   .   $
��auto �6?   6N   .+�53   *   � $��0��6/   .+�54   .     ���#b47fff$��5q�6X    ! PrimaryHueDarkForegroundBrush#���  55   .   $��0q�56   .   $	��200��6:   .��57   2   �  58   6   �� 59   :   $
��Auto �6H   �� 5:   :   $
��Auto �6H   �� 5;   :   $
��Auto �6H   .+�5=   6   �� $��0��6@   $��
16 16 16 4q�6M   $��Số Phiếu Nhập��5>   ,    $  MaterialDesignHeadline5TextBlock#��[ 5?   ,   ���#FFFF5A   7   �� 5B   6   $��1��6@      MaterialDesignLightSeparator#��[ 6M   �� 5C   6   $��2��6@   $��	16 0 16 8q�6M   $��Center=�6`   $
��Left=�5D   ,      MaterialDesignBody1TextBlock#��[ 5F   ,   ��5E   ,   �� *totalEntryBillInDay+5G   7   '  !MaterialDesignThemes.Wpf.PopupBox  5H   6   $��Right=�6N   $��2 0 2 0q�6j      PopupContent. 5I   :   �� 5K   ;   5L   7   5M   3   5N   /   5O   +   � 5Q   *   $��1��6/   .+�5R   .     ���#b47fff$��5q�6W   #���  5S   .   $��0q�5T   .   $	��200��6:   .��5U   2   �  5V   6   �� 5W   :   $
��Auto �6H   �� 5X   :   $
��Auto �6H   �� 5Y   :   $
��Auto �6H   .+�5[   6   �� $��0��6@   $��
16 16 16 4q�6M   $��Số Phiếu Xuất��5\   9   #��[ 5]   9   ���#FFFF5^   7   �� 5_   6   $��1��6@   #��[ 6M   �� 5`   6   $��2��6@   $��	16 0 16 8q�6M   $��Center=�6`   $
��Left=�5a   ,   #��[ 5c   ,   ��5b   ,   �� *totalExportBillInDay+5d   7     5e   6   $��Right=�6N   $��2 0 2 0q�6j   . 5f   :   �� 5h   ;   5i   7   5j   3   5k   /   5l   +   � 5n   *   $��2��6/   .+�5o   .     ���#b47fff$��5q�6X   #���  5p   .   $��0q�5q   .   $	��200��6:   .��5r   2   �  5s   6   �� 5t   :   $
��Auto �6H   �� 5u   :   $
��Auto �6H   �� 5v   :   $
��Auto �6H   .+�5x   6   �� $��0��6@   $��
16 16 16 4q�6M   $��
Tồn kho��5y   ,   #��[ 5z   ,   ���#ffff5|   7   �� 5}   6   $��1��6@   #��[ 6M   �� 5~   6   $��2��6@   $��	16 0 16 8q�6M   $��Center=�6`   $
��Left=�5   ,   #��[ 5�   ,   ��5�   ,   �� *sumQuantityProduct+5�   7     5�   6   $��Right=�6N   $��2 0 2 0q�6j   . 5�   :   �� 5�   ;   5�   7   5�   3   5�   /   5�   +   � 5�   *   $��3��6/   .+�5�   .   ��  & "MaterialDesignFloatingActionButton#��[ 5�      	 � ToolTip$(	 "MaterialDesignFloatingActionButton��5�      {�5�      �� *DataContext.ControlsEnabled+
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType
 Window��5�   1   �� *	ReloadCom+.��5�   2     $ Reload=�5�      5�   /   5�   +   5�   '   5�   #   5�      5�      � 5�      $��1��6    5�      �� 5�   "   66   �� 5�   "   $	��240 �63   6A   .+�5�      � $��0��6#   .+�5�   "   #   LiveCharts.Wpf.CartesianChart  &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$
 Left=�6Y      Series 65   �� *SeriesCollection+   AxisX 5�   *      LiveCharts.Wpf.Axis     Title$  ��63      Labels 6<   �� *Labels+6X      AxisY 5�   *     $  ��63      LabelFormatter 6<   �� *	Formatter+6c   5�   #   5�      �� 5�      $��1��6%    �� Padding$ 0q�65   $��10q�6A   
�������$	��1pxq�6`    �� CornerRadius$ 7��6v   ._�5�   "   &   System.Windows.Controls.Calendar  $	��Top=�6,   6F   5�      5�      5�      5�      �� 5�        EntryBillVM# [ 6   ��5�      �� 5�      $
��auto��6%   $
��auto��62   .+�5�        $��24��66   $��24��6A   $��Center=�6M   $ InvoiceTextPlus=�6j   �� 5�      $��Center=�6(   $��Đơn Nhập��6E   5�      .��5�        $��1��6*   $��5q�67   $��Stretch=�6B   .��5�      �  5�      �� 5�   "   $
��auto �60   6@   �� 5�   "   $
��auto �60   6@   �� 5�   "   62   .+�5�      � $��0��6#   $��5q�60    5�   "   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   �� 5�   &   $��* �67   6C   .+�5�   "   � $��0��6'   .+�5�   &   -	  'MaterialDesignThemes.Wpf.AutoSuggestBox	  $��50��5�   )   )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Nhập mã phiếu...��5�   )   $	��250��5�   )   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5�   )    	  DropDownElevation$	 Dp0=�5�   )    ( $MaterialDesignOutlinedAutoSuggestBox#��[ 5�   )    	  ValueMember$	 Key��5�   )   ��5�   )   �� *	keySearch+ 	  Suggestions 5�   )   �� *AutoSuggestBox2Suggestions+.��5�   ;    	  ItemTemplate 5�   *   �� 5�   .   .R�5�   2   ]� .+�5�   6   �� $��20��5�   9   $��20��5�   9   $ 10��5�   9   �� 5�   6   $��10,0,0,0q�5�   9   5�   3   5�   /   .��5�   V   5�   '   5�   #   � 5�   "   $��1��6'   .+�5�   &   ��  	 MaterialDesignRaisedButton#��[	 6-   $��5q�6a   $	��100��5�   &   $��Search��5�   &   $/	 )Resource name: MaterialDesignRaisedButton��5�   &   ��5�   &   �� *SearchEntryBillCom+5�   \   5�   #   � 5�   "   $��2��6'   .+�5�   &   ��  *
 &MaterialDesignFloatingActionMiniButton#��[
 5�   )   $(	 "MaterialDesignFloatingActionButton��5�   )   $��Right=�5�   )   
��� � �{�5�   )   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5�   )   �� *OpenAddEntryBillCommand+.��5  *     $��30��5  5   $��25��5  5   $ 	PlusThick=�5  5   5  '   �� 5	  &   #��[
 5  (   $(	 "MaterialDesignFloatingActionButton��5  (   
��� ���$��Right=�5  (   $��0,0,60,0q�5  (   {�5
  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5  (   �� *OpenEditFormCommand+.��5  *     $��30��5  4   $��25��5  4   $	 Cog=�5  4   5  '   �� 5  &   #��[
 5  (   $(	 "MaterialDesignFloatingActionButton��5  (   
���  ��$��Right=�5  (   $��	0,0,120,0q�5  (   {�5  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5  (   �� *DeleteEntryBillCom+.��5!  *     $��30��5"  4   $��25��5#  4   $ TrashCanOutline=�5%  4   5'  '   �� 5(  &   #��[
 5*  (   $(	 "MaterialDesignFloatingActionButton��5+  (   
����  �$��Right=�5.  (   $��	0,0,180,0q�5/  (   {�5)  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5,  (   �� *OpenPrintFormCom+.��51  *     $��30��52  4   $��25��53  4   $ NoteEdit=�55  4   56  '   58  #   59     � 5;     $��1��6#   $��45��60    5<  "   �� 5=  &   $	��140 �67   6E   �� 5?  &   $��* �67   6C   .+�5B  "   � $��0��6'   $��	5, 0,0, 0q�67   .+�5C  &   �� $	��120��6/   $
��Left=�5D     $ Theo người tạo��5E      �� DisplayMemberPath$ UserName��5G     ��5F     �� *users+ �� SelectedItem 5H     �� *selectedUser+5K  '   5L  #   � 5N  "   $��2��6'   .+�5O  &   �� #��[	 6-   $��60��5P     $��28��5Q     $��Clear��5R     $��0q�5S     $
��Left=�5U     ��5T     �� *
ClearCom+5W  '   �� 5X  &   #��[	 6-   $��60��5Y     $��28��5Z     $��Lọc��5[     $��0q�5\     $��65,0,0,0q�5]     $
��Left=�5^     ��5_     �� *FilterEntryBillCom+5a  '   �� 5b  &   #��[	 6-   $��60��5c     $��28��5d     $
��load��5e     $��0q�5f     $��	130,0,0,0q�5g     $
��Left=�5h     ��5i     �� *	ReloadCom+5j  '   �� 5k  &   -   5        $��Center=�5k  -   $��Right=�5l     $�� 0,0,5,0q�5m     
������ 
������ .��5r  *     $ 
FilterMenu=�6B   ���#673AB7$��25��6i   $��20��6t    � ContextMenu 5s  *   �� 5t  .   .@�5u  2   m� $��Ngày tạo mới nhất��6m    m� Command 6;   �� *ArrangeTransactionDateDownCom+6m   �� 5v  2   m� 5w  2   $��Ngày tạo cũ nhất��6k    6;   �� *ArrangeTransactionDateUpCom+6k   5x  /   5z  '   5~  #   5�     � 5�     $��2��6#    5�  "   �� 5�  &   $��* �67   6C   .+�5�  "   � $��0��6'   .+�5�  &   �� ��6/   �� *
entryBills+ �� UpdateSourceTrigger$ PropertyChanged=�  �� Mode$  TwoWay=� 6�   �� *selectedItemInView+! �� View! 5�  *   �� 5�  .   .P�5�  2   �� $��Mã Phiếu Nhập��6A   " �� DisplayMemberBinding" 6X   �� *EntryBillId+6�   �� 5�  2   $��Ngày tạo��6A   " 6S   �� *TransactionDate+6�   �� 5�  2   $��Người tạo��6A   " 6T   �� *User.UserName+6�   �� 5�  2   $ ��Số lượng sản phẩm��6A   " 6\   �� *CountProduct+6�   �� 5�  2   $��
Gía trị��6A   " 6R   �� *EntryBillPrice+6�   5�  /   5�  '   5�  #   5�     5�     5�     5�     �� 5�       ExportBillVM# [ 6   ��5�     �� 5�     $
��auto��6%   $
��auto��62   .+�5�       $��24��66   $��24��6A   $��Center=�6M   $ InvoiceTextRemove=�6j   �� 5�     $��Center=�6(   $��Đơn Xuất��6E   5�     .��5�       $��1��6*   $��5q�67   $��Stretch=�6B   .��5�     �  5�     �� 5�  "   $
��auto �60   6@   �� 5�  "   $
��auto �60   6@   �� 5�  "   62   .+�5�     � $��0��6#   $��5q�60    5�  "   �� 5�  &   $
��auto �67   6F   �� 5�  &   $
��auto �67   6F   �� 5�  &   $��* �67   6C   .+�5�  "   � $��0��6'   .+�5�  &   	  $��50��5�  )   $ Nhập mã phiếu...��5�  )   $	��250��5�  )   $
 True��5�  )   $	 Dp0=�5�  )   #��[ 5�  )   $	 Key��5�  )   ��5�  )   �� *	keySearch+ 5�  )   �� *AutoSuggestBox2Suggestions+.��5�  ;    5�  *   �� 5�  .   .R�5�  2   ]� .+�5�  6   �� $��20��5�  9   $��20��5�  9   $ 10��5�  9   �� 5�  6   $��10,0,0,0q�5�  9   5�  3   5�  /   .��5�  V   5�  '   5�  #   � 5�  "   $��1��6'   .+�5�  &   �� #��[	 6-   $��5q�6a   $	��100��5�  &   $��Search��5�  &   $/	 )Resource name: MaterialDesignRaisedButton��5�  &   ��5�  &   �� *SearchExportBillsCom+5�  \   5�  #   � 5�  "   $��2��6'   .+�5�  &   �� #��[
 5�  )   $(	 "MaterialDesignFloatingActionButton��5�  )   $��Right=�5�  )   
��� � �{�5�  )   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5�  )   �� *OpenAddExportBillFormCom+.��5�  *     $��30��5�  5   $��25��5�  5   $ 	PlusThick=�5�  5   5�  '   �� 5�  &   #��[
 5�  (   $(	 "MaterialDesignFloatingActionButton��5�  (   
��� ���$��Right=�5�  (   $��0,0,60,0q�5�  (   {�5�  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5�  (   �� *OpenEditFormCom+.��5�  *     $��30��5�  4   $��25��5�  4   $	 Cog=�5�  4   5�  '   �� 5�  &   #��[
 5�  (   $(	 "MaterialDesignFloatingActionButton��5   (   
���  ��$��Right=�5  (   $��	0,0,120,0q�5  (   {�5�  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5  (   �� *DeleteEntryBillCom+.��5  *     $��30��5  4   $��25��5  4   $ TrashCanOutline=�5
  4   5  '   �� 5  &   #��[
 5  (   $(	 "MaterialDesignFloatingActionButton��5  (   
����  �$��Right=�5  (   $��	0,0,180,0q�5  (   {�5  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5  (   �� *OpenPrintFormCom+.��5  *     $��30��5  4   $��25��5  4   $ NoteEdit=�5  4   5  '   5  #   5     � 5     $��1��6#   $��45��60    5   "   �� 5!  &   $	��140 �67   6E   �� 5#  &   $��* �67   6C   .+�5&  "   � $��0��6'   $��	5, 0,0, 0q�67   .+�5'  &   �� $	��120��6/   $
��Left=�5(     $ Theo người tạo��5)     $ UserName��5+     ��5*     �� *users+ 5,     �� *selectedUser+5/  '   50  #   � 52  "   $��2��6'   .+�53  &   �� #��[	 6-   $��60��54     $��28��55     $��Clear��56     $��0q�57     $
��Left=�59     ��58     �� *
ClearCom+5;  '   �� 5<  &   #��[	 6-   $��60��5=     $��28��5>     $��Lọc��5?     $��0q�5@     $��65,0,0,0q�5A     $
��Left=�5B     ��5C     �� *FilterExportBillCom+5E  '   �� 5F  &   #��[	 6-   $��60��5G     $��28��5H     $��Reload��5I     $��0q�5J     $��	130,0,0,0q�5K     $
��Left=�5L     ��5M     �� *	ReloadCom+5O  '   �� 5P  &   -   5        $��Center=�5P  -   $��Right=�5Q     $�� 0,0,5,0q�5R     
������ 
������ .��5W  *     $ 
FilterMenu=�6B   ���#673AB7$��25��6i   $��20��6t    5X  *   �� 5Y  .   .@�5Z  2   m� $��Ngày tạo mới nhất��6m    6;   �� *ArrangeTransactionDateDownCom+6m   �� 5[  2   m� 5\  2   $��Ngày tạo cũ nhất��6k    6;   �� *ArrangeTransactionDateUpCom+6k   5]  /   5_  '   5c  #   5i     � 5j     $��2��6#    5k  "   �� 5l  &   $��* �67   6C   .+�5o  "   � $��0��6'   .+�5p  &   �� ��6/   �� *exportBills+$ PropertyChanged=�$  TwoWay=� 6�   �� *selectedItemInView+! 5q  *   �� 5r  .   .P�5s  2   �� $��Mã Phiếu Xuất��6A   " 6X   �� *ExportBillId+6�   �� 5t  2   $��Ngày tạo��6A   " 6S   �� *TransactionDate+6�   �� 5u  2   $��Người tạo��6A   " 6T   �� *User.UserName+6�   �� 5v  2   $ ��Số lượng sản phẩm��6A   " 6\   �� *CountProduct+6�   �� 5w  2   $��
Gía trị��6A   " 6R   �� *ExportBillPrice+6�   5z  /   5|  '   5}  #   5     5�     5�     5�     �� 5�       	SuplierVM# [ 6   ��5�     �� 5�     $
��auto��6%   $
��auto��62   .+�5�       $��24��66   $��24��6A   $��Center=�6M   $ Domain=�6j   �� 5�     $��Center=�6(   $��Nhà CC��6E   5�     .��5�       $��1��6*   $��5q�67   $��Stretch=�6B   .��5�     �  5�     �� 5�  "   $
��auto �60   6@   �� 5�  "   $
��auto �60   6@   �� 5�  "   62   .+�5�     � $��0��6#   $��5q�60    5�  "   �� 5�  &   $
��auto �67   6F   �� 5�  &   $
��auto �67   6F   �� 5�  &   $��* �67   6C   .+�5�  "   � $��0��6'   .+�5�  &   	  $ Nhập tên...��5�  *   $	��250��5�  *   $
 True��5�  *   $	 Dp0=�5�  *   #��[ 5�  *   $	 Key��5�  *   ��5�  *   �� *	keySearch+ 5�  *   �� *AutoSuggestBox2Suggestions+.��5�  <    5�  *   �� 5�  .   .R�5�  2   ]� .+�5�  6   �� $��20��5�  6   $��20��5�  6   $ 10��5�  5   �� 5�  6   $��10,0,0,0q�5�  6   ��5�  6   �� *Key+5�  3   5�  /   .��5�  V   5�  '   5�  #   � 5�  "   $��1��6'   .+�5�  &   �� #��[	 6-   $��5q�6a   $	��100��5�  &   $��Search��5�  &   $/	 )Resource name: MaterialDesignRaisedButton��5�  &   ��5�  &   �� *CSearchSuplier+5�  \   5�  #   � 5�  "   $��2��6'   .+�5�  &   �� #��[
 5�  )   $(	 "MaterialDesignFloatingActionButton��5�  )   $��Right=�5�  )   
��� � �{�5�  )   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5�  )   �� *OpenWindowAddSuplier+.��5�  *     $��30��5�  5   $��25��5�  5   $ 	PlusThick=�5�  5   5�  '   �� 5�  &   #��[
 5�  (   $(	 "MaterialDesignFloatingActionButton��5�  (   
��� ���$��Right=�5�  (   $��0,0,60,0q�5�  (   {�5�  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5�  (   �� *OpenWindowEditSuplier+.��5�  *     $��30��5�  4   $��25��5�  4   $	 Cog=�5�  4   5�  '   �� 5�  &   #��[
 5�  (   $(	 "MaterialDesignFloatingActionButton��5�  (   
���  ��$��Right=�5�  (   $��	0,0,120,0q�5�  (   {�5�  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5�  (   �� *CDeleteSuplier+.��5�  *     $��30��5�  4   $��25��5�  4   $ TrashCanOutline=�5�  4   5�  '   5�  #   5�     � 5�     $��1��6#   .+�5�  "   �� 6.   5�     � 5�     $��2��6#    5�  "   �� 5�  &   $��* �67   6C   .+�5�  "   � $��0��6'   .+�5�  &   �� ��6/   �� *
Supliers+$ PropertyChanged=�$  TwoWay=� 6�   �� *SelectedItem+! 5�  *   �� 5   .   .P�5  2   �� $
��Tên��6A   " 6N   �� *SuplierName+6}   �� 5  2   $��Địa Chỉ��6A   " 6R   �� *SuplierAddress+6�   �� 5  2   $
��SĐT��6A   " 6N   �� *SuplierPhoneNumber+6�   �� 5  2   $��Email��6A   " 6P   �� *SuplierEmail+6�   5  /   5	  '   5
  #   5     5     5     5     �� 5       	ProductVM# [ 6   ��5     �� 5     $
��auto��6%   $
��auto��62   .+�5       $��24��66   $��24��6A   $��Center=�6M   $ Store=�6j   # J� RenderTransformOrigin$# 0.5,0.5&�6w   z�5  "   V� 5  &   .~�5  *   �� �� 5  *   �� 5  *   $ �� Angle$$ -178.375Q�6:   T� 5  *   5  '   5     �� 5     $��Center=�6(   $��	Kho Hàng��6E   5      .��5#       $��1��6*   $��5q�67   $��Stretch=�6B   .��5$     �  5%     �� 5&  "   $
��auto �60   6@   �� 5'  "   $
��auto �60   6@   �� 5(  "   62   .+�5+     � $��0��6#   $��5q�60    5,  "   �� 5-  &   $
��auto �67   6F   �� 5.  &   $
��auto �67   6F   �� 5/  &   $��* �67   6C   .+�52  "   � $��0��6'   .+�53  &   	  $  Nhập mã sản phẩm...��54  *   $	��250��55  *   $
 True��57  *   $	 Dp0=�58  *   #��[ 59  *   $	 Key��5<  *   ��56  *   �� *	keySearch+ 5:  *   �� *AutoSuggestBox2Suggestions+.��5<  <    5>  *   �� 5?  .   .R�5@  2   ]� .+�5A  6   �� $��20��5B  6   $��20��5C  6   $ 10��5D  5   �� 5E  6   $��10,0,0,0q�5F  6   5H  3   5I  /   .��5J  V   5L  '   5N  #   � 5P  "   $��1��6'   .+�5Q  &   �� #��[	 6-   $��5q�6a   $	��100��5R  &   $��Search��5T  &   $/	 )Resource name: MaterialDesignRaisedButton��5U  &   ��5S  &   �� *SearchProductCom+5U  \   5V  #   � 5W  "   $��2��6'   .+�5X  &   �� #��[
 5Z  )   $(	 "MaterialDesignFloatingActionButton��5[  )   $��Right=�5]  )   
��� � �{�5Y  )   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5\  )   �� *OpenWindowAddCom+.��5b  *     $��30��5c  5   $��25��5d  5   $ 	PlusThick=�5f  5   5g  '   �� 5h  &   #��[
 5j  (   $(	 "MaterialDesignFloatingActionButton��5k  (   
��� ���$��Right=�5n  (   $��0,0,60,0q�5o  (   {�5i  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5l  (   �� *OpenWindowEditCom+.��5q  *     $��30��5r  4   $��25��5s  4   $	 Cog=�5u  4   5v  '   �� 5w  &   #��[
 5y  (   $(	 "MaterialDesignFloatingActionButton��5z  (   
���  ��$��Right=�5}  (   $��	0,0,120,0q�5~  (   {�5x  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5{  (   �� *DeleteProductCom+.��5�  *     $��30��5�  4   $��25��5�  4   $ TrashCanOutline=�5�  4   5�  '   5�  #   5�     � 5�     $��1��6#   $��45��60    5�  "   �� 5�  &   $	��140 �67   6E   �� 5�  &   $	��140 �67   6E   �� 5�  &   $��* �67   6C   .+�5�  "   � $��0��6'   $��	5, 0,0, 0q�67   .+�5�  &   �� $	��120��6/   $
��Left=�5�  /   $ Theo thể loại��5�  /   $ CategoryName��5�  /   ��5�  /   �� *
categories+ 5�  /   �� *selectedCateFilter+5�  '   5�  #   � 5�  "   $��1��6'   .+�5�  &   �� $	��120��6/   $
��Left=�5�  /   $ Theo nhà cung cấp��5�  /   $ SuplierName��5�  /   ��5�  /   �� *
supliers+ 5�  /   �� *selectedSupFilter+5�  '   5�  #   � 5�  "   $��2��6'   .+�5�  &   �� #��[	 6-   $��60��5�  -   $��28��5�  -   $��Clear��5�  -   $��0q�5�  -   $
��Left=�5�  -   ��5�  -   �� *
ClearCom+5�  '   �� 5�  &   #��[	 6-   $��60��5�  -   $��28��5�  -   $��Lọc��5�  -   $��0q�5�  -   $��65,0,0,0q�5�  -   $
��Left=�5�  -   ��5�  -   �� *FilterProductCom+5�  '   �� 5�  &   #��[	 6-   $��60��5�  -   $��30��5�  -   $��0q�5�  -   $��Reload��5�  -   $��	140,0,0,0q�5�  -   $
��Left=�5�  -   ��5�  -   �� *	ReloadCom+5�  '   �� 5�  &   -   5        $��Center=�5�  -   $��Right=�5�  -   $�� 0,0,5,0q�5�  -   
������ 
������ .��5�  *     $ 
FilterMenu=�6B   ���#673AB7$��25��6i   $��20��6t    5�  *   �� 5�  .   .@�5�  2   m� $��Tồn kho giảm dần��6f    6;   �� *ArrangeQuantityDownCom+6f   �� 5�  2   m� 5�  2   $��Tồn kho tăng dần��6d    6;   �� *ArrangeQuantityUpCom+6d   �� 5�  2   m� 5�  2   $%��Ngày cập nhật mới nhất��6g    6;   �� *ArrangeUpdateDayDownCom+6g   5�  /   5�  '   5�  #   5�     � 5�     $��2��6#    5�  "   �� 5�  &   $��* �67   6C   .+�5�  "   � $��0��6'    5�  &   �� 5�  *   $
��441* �6;   �� 5�  *   $
��277* �6;    5�  &   �� 5�  *   $
��141* �68   �� 5�  *   $
��218* �68   .+�5�  &   �� $��2��6v   $��2��6�   ��6/   �� *
products+ 6P   �� *selectedItem+! 5�  *   �� 5�  .   .P�5�  2   �� $�� ��6A   % �� CellTemplate% 5�  6   �� 5�  :   .R�5�  >   �� $��70��6]   $��70��6h   ��6D   �� *image+6h   5�  ;   5   3   �� 5  2   $��Mã sản phẩm��6A   " 6V   �� *	ProductId+6�   �� 5  2   $
��Tên��6A   " 6N   �� *ProductName+6}   �� 5  2   $��	Tồn kho��6A   " 6R   �� *
Quantity+6   �� 5  2   $��Gía Nhập��6A   " 6S   �� *
EnTryPrice+6�   �� 5  2   $��Gía Xuất��6A   " 6S   �� *ExportPrice+6�   �� 5  2   $��Nhà cung cấp��6A   " 6W   �� *Suplier.SuplierName+6�   �� 5  2   $��Ngày Cập nhật��6A   " 6X   �� *	UpdateDay+6�   �� 5  2   $��Thể loại��6A   " 6S   �� *Category.CategoryName+6�   5  /   5  '   5  #   5     5     5     5     �� 5      
 CateVM# [ 6   ��5     �� 5     $
��auto��6%   $
��auto��62   .+�5       $��24��66   $��24��6A   $��Center=�6M   $ Shape=�6j   �� 5     $��Center=�6(   $��Thể Loại��6E   5     .��5       $��1��6*   $��5q�67   $��Stretch=�6B   .��5     �  5     �� 5  "   $
��auto �60   6@   �� 5   "   $
��auto �60   6@   .+�5$     � $��0��6#   $��5q�60    5%  "   �� 5&  &   $
��auto �67   6F   �� 5'  &   $
��auto �67   6F   �� 5(  &   $��* �67   6C   .+�5+  "   � $��0��6'   .+�5,  &   	  $��50��5-  )   $! Nhập tên thể loại...��5.  )   $	��250��5/  )   $
 True��51  )   $	 Dp0=�52  )   #��[ 53  )   $	 Key��56  )   ��50  )   �� *	keySearch+ 54  )   �� *AutoSuggestBox2Suggestions+.��56  ;    58  *   �� 59  .   .R�5:  2   ]� .+�5;  6   �� $��20��5<  9   $��20��5=  9   $ 10��5>  9   �� 5?  6   $��10,0,0,0q�5@  9   5B  3   5C  /   .��5D  V   5F  '   5H  #   � 5J  "   $��1��6'   .+�5K  &   �� #��[	 6-   $��5q�6a   $	��100��5L  &   $��Search��5N  &   $/	 )Resource name: MaterialDesignRaisedButton��5O  &   ��5M  &   �� *SearchCateCom+5O  \   5P  #   � 5Q  "   $��2��6'   .+�5R  &   �� #��[
 5T  )   $(	 "MaterialDesignFloatingActionButton��5U  )   $��Right=�5W  )   
��� � �{�5S  )   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5V  )   �� *OpenAddFormCom+.��5\  *     $��30��5]  5   $��25��5^  5   $ 	PlusThick=�5`  5   5a  '   �� 5b  &   #��[
 5d  (   $(	 "MaterialDesignFloatingActionButton��5e  (   
��� ���$��Right=�5h  (   $��0,0,60,0q�5i  (   {�5c  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5f  (   �� *OpenEditFormCom+.��5k  *     $��30��5l  4   $��25��5m  4   $	 Cog=�5o  4   5p  '   �� 5q  &   #��[
 5s  (   $(	 "MaterialDesignFloatingActionButton��5t  (   
���  ��$��Right=�5w  (   $��	0,0,120,0q�5x  (   {�5r  (   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window��5u  (   �� *DelCategoryCom+.��5z  *     $��30��5{  4   $��25��5|  4   $ TrashCanOutline=�5~  4   5�  '   5�  #   5�     � 5�     $��1��6#    5�  "   �� 5�  &   $��* �67   6C   .+�5�  "   � $��0��6'    5�  &   �� 5�  *   $
��149* �6;   �� 5�  *   $
��310* �6;   �� 5�  *   .+�5�  &   �� $��2��6�   ��6/   �� *
categories+$ PropertyChanged=�$  TwoWay=� 6�   �� *SelectedItem+! 5�  *   �� 5�  .   .P�5�  2   �� $��Mã Thể Loại��6A   " 6V   �� *
CategoryId+6�   �� 5�  2   $��Tên Thể Loại��6A   " 6W   �� *CategoryName+6�   5�  /   5�  '   5�  #   5�     5�     5�     5�     �� 5�     -   5        & ��Name$& TabItemUserVM��5�      
 UserVM# [ 61   ��5�     �� 5�     $
��auto��6%   $
��auto��62   .+�5�       $��24��66   $��24��6A   $��Center=�6M   $ AccountCircle=�6j   �� 5�     $��Center=�6(   $��Tài Khoản��6E   5�     .��5�     �  5�     �� 5�     61   �� 5�     $	��200 �6/   6=   .+�5�     � $��0��6    5�     �� 5�  "   63   �� 5�  "   $	��100 �60   6?   .+�5�     � $��0��6#   $��0,0,0,5q�60    5�  "   �� 5�  &   $��50 �64   6B   �� 5�  &   66   .+�5�  "   � $��0��6'   .+�5�  &   �� $��15(�60   $
��Bold"�6>   $��Times New Roman)�6P   $��Bottom=�6m   $��	10,0,0,10q�6�   Thông Tin Cá Nhân5�  '   5�  #   � 5�  "   $��1��6'    5�  &   �� 5�  *   $	��200 �6;   6I   �� 5�  *   6=   .+�5�  &   �� $��	10,0,10,0q�6-   $��0��6@   
�������$	��1pxq�6c   $ 10��6y   ._�5�  *   �� .+�5�  .   �� ���#673AB7$��6q�6K   $��Center=�6_   $��0,20,0,0q�6|   $	��Top=�6�   $ 70��6�   ._�5�  2   A� $	��128��6:   $	��128��6F   ��5�  6   �� 5�  :   ' �� ImageSource' 6E   �� *	imgSource+5�  3   5�  /   �� 5�  .   $	��120��5�  1   $��0,10,0,0q�5�  1   $��
Thay ảnh��5�  1   #��[	 5�  1   $/	 )Resource name: MaterialDesignRaisedButton��5�  1   ��5�  1   �� *
LoadAnhCom+5�  1   �� 5�  .   $	��140��5�  0   $��Bottom=�5�  0   $��	0,110,0,0q�5�  0   $��0q�5�  0   $��Chỉnh sửa thông tin��5�  0   #��[	 5�  0   $/	 )Resource name: MaterialDesignRaisedButton��5�  0   ��5�  0   �� *EditUserCom+{�5�  0   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window5�  0   5�  +   5�  '   �� 5�  &   $��1��6-   
�������$	��1pxq�6P   $ 10��6f   ._�5�  *   �  5�  .   �� 5�  2   5�  3   �� 5�  2   5�  3   �� 5�  2   5�  3   .+�5�  .   � $��0��63   .+�5�  2   �� $��Center=�6=   ( �� Orientation$( 
Horizontal=�6Z   .+�5�  6   �� $	��400��5�     $��0,0,20,0q�5�     $	��190��5�     $��Center=�5�     $ 	Họ Tên��5�     ) �� AcceptsReturn$
) True��5        MaterialDesignFilledTextBox#��[ 5     ��5     �� *user.DisplayName+5     �� 5  6   $	��400��5     $	��190��5     $��Center=�5	     $ Giới tính��5
     $
) True��5     #��[ 5     * �� TextWrapping$
* Wrap=�5     ��5     �� *
user.sex+5     5  3   5  /   � 5  .   $��1��63   .+�5  2   �� $��Center=�6=   $( 
Horizontal=�6Z   .+�5  6   �� $	��400��5     $��0,0,20,0q�5  6   $	��190��5  5   $��Center=�5     $ Tuổi��5     $
) True��5     #��[ 5     $
* Wrap=�5     ��5  6   �� *
user.age+{�5     �� + �� Path$+ 	IsChecked�, �� ElementName$0, *MaterialDesignFilledTextBoxEnabledComboBox��5     �� 5!  6   $	��400��5#     $	��190��5&  5   $��Center=�5'     $ Số điện thoại��5(     $
) True��5)     #��[ 5+     $
* Wrap=�5,     ��5$  5   �� *user.PhoneNumber+{�5*     �� $+ 	IsChecked�$0, *MaterialDesignFilledTextBoxEnabledComboBox��5,     5.  3   50  /   � 51  .   $��2��63   .+�52  2   �� $( Vertical=�6=   .+�53  6   �� $	��400��54     $��
10,0,10,20q�55     $��Center=�57     $ Địa chỉ��58     $
) True��59     #��[ 5;     $
* Wrap=�5<     ��56     �� *user.Address+{�5:     �� $+ 	IsChecked�$0, *MaterialDesignFilledTextBoxEnabledComboBox��5<     �� 5>  6   $��
10, 0,10,0q�5?     $	��400��5@     $��Center=�5B     $ Email��5C     $
) True��5D     #��[ 5F     $
* Wrap=�5G     ��5A     �� *
user.Email+{�5E     �� $+ 	IsChecked�$0, *MaterialDesignFilledTextBoxEnabledComboBox��5G     5I  3   5K  /   5M  +   5N  '   5Q  #   5R     �� 5S     $��	10,5,0,10q�6%   $��1��68   
�������$	��1pxq�6X   $ 10��6n   ._�5T  "   � .+�5U  &   �� $( 
Horizontal=�61   .+�5V  *   �� $	��400��5W     $	��170��5X  -   $��	10,0,20,0q�5Z  -   $��Center=�5[     $ Username��5\     $
) True��5]     #��[ 5_     $
* Wrap=�5`     ��5Y  -   �� *user.UserName+{�5^     �� $+ 	IsChecked�$0, *MaterialDesignFilledTextBoxEnabledComboBox��5`     �� 5b  *   $	��400��5c     $	��170��5d  .   $��	10,0,20,0q�5e     $��Center=�5f     $ Mật khẩu (***)��5g     $
) True��5h     #��[ 5j     $
* Wrap=�5k     {�5i     �� $+ 	IsChecked�$0, *MaterialDesignFilledTextBoxEnabledComboBox��5k     �� 5m  *   $	��120��5n     $��Dổi mật khẩu��5o     #��[	 5r     $/	 )Resource name: MaterialDesignRaisedButton��5s     ��5p  -   �� *OpenChangePassWCom+{�5q     �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window5s     5u  '   5w  #   5x     5z     � 5{     $��1��6    5|     �� 5}  "   $��50 �60   6>   �� 5~  "   62   .+�5�     � $��0��6#   5�     �� 5�     $��
10,0,10,10q�6%   $��1��69   
�������$	��1pxq�6Y   $ 10��6o   ._�5�  "   �  5�  &   �� 5�  *   $	��100 �68   6G   �� 5�  *   6:   .+�5�  &   � $��0��6+   .+�5�  *   #  MaterialDesignThemes.Wpf.Chip  $��Center=�5�  -   $��20,0,0,0q�5�  -   ��5�  1   �� *user.Role.RoleName+-   Icon- 5�  .   �� 5�  2   ��5�  5   �� *	imgSource+5�  +   5�  '   � 5�  &   $��1��6+   .+�5�  *   �� $	��120��5�     $��Bottom=�5�     $��0,0,0,35q�5�     $��Đăng xuất��5�     #��[	 5�     $/	 )Resource name: MaterialDesignRaisedButton��5�     ��5�     �� *	LogoutCom+{�5�     �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window5�     5�  '   5�  #   5�     5�     5�     5�     5�     5�     5�     5�     