   M S B A M L   `   `   `  ����F  BQuanLyKhoPJ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:QuanLyKhoPJ.View.ExportBillQuanLyKhoPJ.View.ExportBill  5   	   3    -QuanLyKhoPJ.View.ExportBill.AddExportBillForm   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   5local)clr-namespace:QuanLyKhoPJ.View.ExportBill  5   	      ExportBillVM  � DataContext#  [  5	   	    � Icon$, &pack://application:,,,/Icon/forest.png��5
   	    � Title$ Fstock��5   	   $��Times New Roman)�6   $	��600��5   	   $
��1020��6   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      �� $��Thêm Phiếu Xuất��6   $��24(�6/   $��Center=�6=   $
��Bold"�6Z   $��0,0,0,20q�6l   $��2��6~   5      � 5   
   $��1��6   .+�5      �� 6   5      � 5   
   $��2��6    � ColumnDefinitions 5      �� 5      $	��800 �6#   61   �� 5      $	��200 �6#   61   .+�5"      � $��0��6    5#      �� 5$      6&   �� 5%      6&   .+�5)      � $��0��6    5*      �� 5+      6-   �� 5,      6.   .+�5/      �� $��0��6   
�������$��1q�6@    �� CornerRadius$ 5��6T   $��5q�6e   ._�50      � .+�51      �� $
��auto��6�   ��6'   �� *
products+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 6|   �� *selectedProductAddBill+	 �� View	 52   "   �� 53   &   .P�54   *   �� $��Mã Sản Phẩm��69   
 �� DisplayMemberBinding
 6N   �� *	ProductId+6{   �� 55   *   $
��Tên��69   
 6F   �� *ProductName+6u   �� 56   *   $��Số Lượng��69   
 6K   �� *
Quantity+6w   58   '   5:      5<      5=      �� 5?      $��1��6   
�������$��1q�6@   $ 5��6T   $��5q�6e   ._�5@      �  5A      �� 5B   "   62   �� 5C   "   62   �� 5D   "   62   .+�5H      � $��0��6#   .+�5J   "   �� $��Center=�5K   !   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã sản phẩm��5L   !   $	��110��5M   !   ${�False��5N   !   $��5,0,0,0q�5P   !   $
��Left=�5Q   !    % !MaterialDesignFloatingHintTextBox#��[ 5R   !   ��5O   !   �� *" selectedProductAddBill.ProductId+$ PropertyChanged=�$ TwoWay=�5R   !   �� 5S   "   $��Center=�5T   !   $ Tên sản phẩm��5U   !   $��0,0,5,0q�5V   !   $	��110��5W   !   ${�False��5X   !   $��Right=�5Z   !   #��[ 5[   !   ��5Y   !   �� *$"selectedProductAddBill.ProductName+$ PropertyChanged=�$ TwoWay=�5[   !   �� 5\   "   $��Center=�5]   !   $ Gía nhập��5^   !   $��0,0,5,0q�5_   !   $	��110��5`   !   ${�False��5a   !   $��Center=�5c   !   #��[ 5d   !   ��5b   !   �� *#!selectedProductAddBill.EnTryPrice+$ PropertyChanged=�$ TwoWay=�5d   !   5g      � 5h      $��1��6#   .+�5j   "   �� $��Center=�5k   !   $ Số lượng xuất��5l   !   $	��110��5m   !   $��0,0,5,0q�5o   !   $��Right=�5p   !   #��[ 5q   !   ��5n   !   �� *quantityAdd+5q   !   5u      � 5x      $��2��6#   .+�5y   "   �� $	��120��5z   	   $��Right=�5{   	   $��0,0,5,0q�5|   	   $	��Add��5}   	     MaterialDesignRaisedButton#��[ 5�   	    � ToolTip$8 2Resource name: MaterialDesignRaisedSecondaryButton��5�   	   ��5~   	   �� *AddProductIntoListBillCom+{�5   	   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5�   	   �� 5�   "   $	��120��5�   	   $��Delete��5�   	   $��0,0,50,0q�5�   	   #��[ 5�   	   $/ )Resource name: MaterialDesignRaisedButton��5�   	   ��5�   	   �� *deleteProductOuttoListBillCom+{�5�   	   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5�   	   5�      5�      5�      5�      � 5�      $��1��6   .+�5�      �� $��0��6   
�������$��1q�6@   $ 5��6T   $��5q�6e   ._�5�      � .+�5�      �� $
��auto��6�   ��6'   �� *listProductsInBill+$ PropertyChanged=�$ TwoWay=� 6�   �� *selectedItemInBill+	 5�   "   �� 5�   &   .P�5�   *   �� $��Mã Sản Phẩm��69    �� Width$
 auto��6N   
 6[   �� *	ProductId+6�   �� 5�   *   $
��Tên��69   $
 auto��6F   
 6S   �� *ProductName+6�   �� 5�   *   $��Thể loại��69   $
 auto��6K   
 6X   �� *Category.CategoryName+6�   �� 5�   *   $��Nhà cung cấp��69   $
 auto��6O   
 6\   �� *Suplier.SuplierName+6�   �� 5�   *   $��Số lượng nhập��69   $
 auto��6P   
 6]   �� *QuantityAddInBill+6�   5�   '   5�      5�      5�      5�      5�      �� 5�      $��1��6   
�������$��1q�68   $ 5��6L   $��5q�6]   ._�5�      � .+�5�      �� $	��Top=�5�      $ Mã Phiếu Nhập��5�      $��5q�5�      ${�False��5�      #��[ 5�      ��5�      �� *entryBill.EntryBillId+5�      �� 5�      $ Nhân viên tạo��5�      $	��Top=�5�       �� DisplayMemberPath$ UserName��5�      $��	5, 53,5,5q�5�      ��5�      �� *users+ 5�      �� *selectedUser+5�      (  "System.Windows.Controls.DatePicker  5�      $��	5, 90,5,5q�5�      $��40��5�      $	��Top=�5�      $��Stretch=�5�      $ Ngày tạo��5�      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5�       ( $MaterialDesignFloatingHintDatePicker#��[ 5�      �� 5�      $	��Top=�5�      $��	5,138,5,5q�5�      $ Tổng số sản phẩm��5�      #��[ 5�      ��5�      �� *countProductInList+5�      �� 5�      $��5,0,5,50q�6!   $��Bottom=�63    �� Orientation$ 
Horizontal=�6N   .+�5�      �� .��6    Tổng Tiền:6,   �� 5�      $��Center=�6$   ��6?   �� *
totalPrice+5�      5�      �� 5�      #��[ 6   $��10q�5�      $��Bottom=�5�      $��Stretch=�5�      $��Tạo Phiếu Nhập��5�      $/ )Resource name: MaterialDesignRaisedButton��5�      ��5�      �� *AddExportBillCom+5�   O   5�      5�      5�      5�      5�      