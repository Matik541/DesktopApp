   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.WindowBinding   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  WindowBinding??5   	   $	??450??6   $	??800??6,   .??5	      ?? .+?5
   
   ?? -   5         ??Name$ fontSize??5
       ? Value$ 20Q?6#    ? Minimum$ 10Q?6.    ? Maximum$	 150Q?6;   ?? 5   
   -   5         ??Name$
 text??5      $??15(?6    ?? 5   
   -   5         ??Name$ 
fontFamily??5      .@?5      ?? $??Arial??6    ?? 
IsSelected$
 True??6+   ?? 5      $??Brush Script MT??6   ?? 5      $??	Yu Gothic??6   5      ?? 5   
   ??5      ??  ?? ElementName$
 text??	 ?? Path$
	 Text???5      ?? $ fontSize??$	 Value???5      ?? $ 
fontFamily??$	 SelectedItem.Content??? 5   
   ?? 5   
   -   5        $
 real??5      ??6    ?? $
 fake??$
	 Text?
 ?? UpdateSourceTrigger$
 PropertyChanged=??? 5   
   -   5        $
 fake??5      ?? 5   
   ?? 5   
   -   5        $ 
slideValue??5      $
 -100Q?5      $	 100Q?5       ?? IsSnapToTickEnabled$
 True??5       ?? TickPlacement$ BottomRight=?6(    5      ?? $ 	textValue??$
	 Text?5   (   ?? 5!   
   -   5        $ 	textValue??5!      ?? 5"   
   ?? 5#   
   -   5        $ onFocusChange??5#      ??6)   ?? $ onFocusDesplay??$
	 Text?$
 	LostFocus=??? 5$   
   -	   5         ??Name$ onFocusDesplay??5$      5'      5(      