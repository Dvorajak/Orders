   M S B A M L   `   `   `  ????K  GWPF_Orders_Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPF_Orders_Views.ViewsWPF_Orders_Views.Views  5      '    !WPF_Orders_Views.Views.DetailView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WPF_Orders_Views.Views     5      $??15(?5   7   .??5	      ? $??10q?6     ? RowDefinitions  5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??2* ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??6"   $??Center=?62    ?? Orientation$ 
Horizontal=?6M   .+?5      ?? $??Název:??6   ?? 5      ??6   ?? *Name+5      ?? 5   
   $??1??6   $??0??6"   $??Center=?62   $ 
Horizontal=?6M   .+?5      ?? $??Datum dokončení:??6   ?? 5      ??6   ?? *
FinishDate+5      ?? 5!   
   $??0??6   $??1??6"   $??Center=?62   $ 
Horizontal=?6M   .+?5"      ?? $??Č. zakázky:??6   ?? 5#      ??6   ?? *OrderNumber+5$      ?? 5&   
   $??1??6   $??1??6"   $??Center=?62   $ 
Horizontal=?6M   .+?5'      ?? $??Zákazník ID:??6   ?? 5(      ??6   ?? *
CustomerId+5)      ?? 5+   
   $??2??6   $??0??6"   $??Center=?62   $ 
Horizontal=?6M   .+?5,      ?? $"??Zbývá dnů na dokončení:??6   ?? 5-      ??6   ?? *
TimeLeft+5.      ?? 50   
   $??3??6   $??0??6"   $??2??62   .+?51      ?? $??Popis:??6   ?? 52      $
??Wrap=?6   $	??100??6N   $??5 0 5 0q?6[   ??6,   ?? *OrderDescription+6[   53      ?? 55   
   $??0??6   $??2??6!   $??4??65   $??OK??6B   $	??100??6i   $??50??6u   ??6O   ?? *Close+6u   57      58      