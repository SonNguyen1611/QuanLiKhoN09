   M S B A M L   `   `   `  ����  QuanLyKhoPJ(    "QuanLyKhoPJ.View.EditEntryBillForm   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5   	   $
��1020��6      EntryBillVM  � DataContext#  [  5   	    � Icon$, &pack://application:,,,/Icon/forest.png��5   	    � Title$ Fstock��5   	   $��Times New Roman)�6   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      �� $"��Chỉnh Sửa Phiếu Nhập��6   $��24(�64   $��Center=�6B   $
��Bold"�6_   $��0,0,0,20q�6q   $��2��6�   5      � 5   
   $��1��6   .+�5      �� 6   5      � 5   
   $��2��6    � ColumnDefinitions 5      �� 5      $	��800 �6#   61   �� 5      $	��200 �6#   61   .+�5!      � $��0��6    5"      �� 5#      6&   �� 5$      6&   .+�5(      � $��0��6    5)      �� 5*      6-   �� 5+      6.   .+�5.      �� $��0��6   
�������$��1q�6@    �� CornerRadius$ 5��6T   $��5q�6e   ._�5/      � .+�50      �� $
��auto��6�   ��6'   �� *
products+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 6|   �� *selectedProductAddBill+	 �� View	 51   "   �� 52   &   .P�53   *   �� $��Mã Sản Phẩm��69   
 �� DisplayMemberBinding
 6N   �� *	ProductId+6{   �� 54   *   $
��Tên��69   
 6F   �� *ProductName+6u   �� 55   *   $��Số Lượng��69   
 6K   �� *
Quantity+6w   57   '   59      5;      5<      �� 5>      $��1��6   
�������$��1q�6@   $ 5��6T   $��5q�6e   ._�5?      �  5@      �� 5A   "   62   �� 5B   "   62   �� 5C   "   62   .+�5G      � $��0��6#   .+�5I   "   �� $��Center=�5J   %   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã sản phẩm��5K   %   $	��110��5L   %   ${�False��5M   %   $��5,0,0,0q�5O   %   $
��Left=�5P   %    % !MaterialDesignFloatingHintTextBox#��[ 5Q   %   ��5N   %   �� *" selectedProductAddBill.ProductId+$ PropertyChanged=�$ TwoWay=�5Q   %   �� 5R   "   $��Center=�5S   %   $ Tên sản phẩm��5T   %   $��0,0,5,0q�5U   %   $	��110��5V   %   ${�False��5W   %   $��Right=�5Y   %   #��[ 5Z   %   ��5X   %   �� *$"selectedProductAddBill.ProductName+$ PropertyChanged=�$ TwoWay=�5Z   %   �� 5[   "   $��Center=�5\   %   $ Gía nhập��5]   %   $��0,0,5,0q�5^   %   $	��110��5_   %   ${�False��5`   %   $��Center=�5b   %   #��[ 5c   %   ��5a   %   �� *#!selectedProductAddBill.EnTryPrice+$ PropertyChanged=�$ TwoWay=�5c   %   5f      � 5g      $��1��6#   .+�5i   "   �� $��Center=�5j   %   $ Số lượng nhập��5k   %   $	��110��5l   %   $��0,0,5,0q�5n   %   $��Right=�5o   %   #��[ 5p   %   ��5m   %   �� *quantityAdd+5p   %   5t      � 5w      $��2��6#   .+�5x   "   �� $	��120��5y      $��Right=�5z      $��0,0,5,0q�5{      $	��Add��5|        MaterialDesignRaisedButton#��[ 5       � ToolTip$8 2Resource name: MaterialDesignRaisedSecondaryButton��5�      ��5}      �� *AddProductIntoListBillCom+{�5~      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5�      �� 5�   "   $	��120��5�      $��Delete��5�      $��0,0,50,0q�5�      #��[ 5�      $/ )Resource name: MaterialDesignRaisedButton��5�      ��5�      �� *deleteProductOuttoListBillCom+{�5�      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5�      5�      5�      5�      5�      � 5�      $��1��6   .+�5�      �� $��0��6   
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
�������$��1q�68   $ 5��6L   $��5q�6]   ._�5�      � .+�5�      �� $	��Top=�5�      $ Mã Phiếu Nhập��5�      $��5q�5�      ${�False��5�      #��[ 5�      ��5�      �� *entryBill.EntryBillId+5�      �� 5�      $ Nhân viên tạo��5�      $	��Top=�5�       �� DisplayMemberPath$ UserName��5�      $��	5, 53,5,5q�5�      ��5�      �� *users+ 5�      �� *selectedUser+5�      (  "System.Windows.Controls.DatePicker  5�      $��	5, 90,5,5q�5�      $��40��5�      $	��Top=�5�      $��Stretch=�5�      $ Ngày cập nhật��5�      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5�       ( $MaterialDesignFloatingHintDatePicker#��[ 5�         SelectedDate 5�      �� *entryBill.TransactionDate+5�      �� 5�      $	��Top=�5�      $��	5,138,5,5q�5�      $ Tổng số sản phẩm��5�      #��[ 5�      ��5�      �� *countProductInList+5�      �� 5�      $��5,0,5,50q�6!   $��Bottom=�63    �� Orientation$ 
Horizontal=�6N   .+�5�      �� .��6    Tổng Tiền:6,   �� 5�      $��Center=�6$   ��6?   �� *
totalPrice+5�      5�      �� 5�      #��[ 6   $��10q�5�      $��Bottom=�5�      $��Stretch=�5�      $��Chỉnh Sửa Phiếu��5�      $/ )Resource name: MaterialDesignRaisedButton��5�      ��5�      �� *EditEntryBillCom+5�   S   5�      5�      5�      5�      5�      