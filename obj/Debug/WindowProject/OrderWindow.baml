   M S B A M L   `   `   `  ����C  ?ExamTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ExamTest.WindowProjectExamTest.WindowProject  5   	   (    "ExamTest.WindowProject.OrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ExamTest.WindowProject     5   	   $	��450��5   	   $	��800��6   $	��450��6(   $	��800��65     � WindowStartupLocation$  CenterScreen=�6A   .��5	      � .+�5
   
   �� $+��%Формирование заказа��6   $��Center=�6.   $��0,10,0,0q�6K   $	��Top=�6]   $��48(�6u   �� 5   
   $!��Список товаров��6   $��Center=�6)   $��0,76,0,0q�6F   $	��Top=�6X   $��28(�6p   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ OrderDataGrid��5         AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   $��
0,128,0,67q�6h      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Изображение��6)      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *	PathImg+5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *NameProduct+  5      $ Описание��6%    67   �� *Description+  5      $ Поставщик��6%    68   �� *Producer.NameProducer+  5      $ Цена��6%    63   �� *Cost+  5      $ Скидка��6%    65   �� *
Discount+  5      $ Количество��6%    69   �� *CountOrderProduct+5      �� 5   
   $ ��Статус заказа:��6   $
��Left=�6)   $��
10,372,0,0q�6D   $	��Top=�6X   $��14(�6p   �� 5   
   $��
Новый��6   $
��Left=�6    $��113,372,0,0q�6;   $	��Top=�6P   $��14(�6h   $��64��6v   $��30��6�   $
��Bold"�6�   �� 5   
   $��Сумма заказа:��6   $
��Left=�6(   $��182,372,0,0q�6C   $	��Top=�6X   $��14(�6p   �� 5    
   -   5        	 ��Name$	 SumOrderLable��5       $
��Left=�6(   $��287,372,0,0q�6C   $	��Top=�6X   $��14(�6p   $��89��6~   $��30��6�   $
��Bold"�6�   �� 5!   
   $��Сумма скидок:��6   $
��Left=�6(   $��381,372,0,0q�6C   $	��Top=�6X   $��14(�6p   �� 5"   
   -   5        $	 DiscountOrderLable��5"      $
��Left=�6-   $��489,372,0,0q�6H   $	��Top=�6]   $��14(�6u   $��90��6�   $��30��6�   $
��Bold"�6�   �� 5#   
   -   5        
 ��Name$
 	CouponBtn��5#      $��Заказать��6$   $
��Left=�67   $��611,372,0,0q�6R   $	��Top=�6g   $��30��6   $��92��6�   $��14(�6�   6�   �� 5$   
   -   5        $
 BackBtn��5$      $��
Назад��6"   $
��Left=�62   $��708,372,0,0q�6M   $	��Top=�6b   $��30��6z   $��68��6�   $��14(�6�   6�   5%      5&      