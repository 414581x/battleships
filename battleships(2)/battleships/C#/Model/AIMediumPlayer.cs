/ /   ' '   < s u m m a r y >  
 / /   ' '   T h e   A I M e d i u m P l a y e r   i s   a   t y p e   o f   A I P l a y e r   w h e r e   i t   w i l l   t r y   a n d   d e s t r o y   a   s h i p  
 / /   ' '   i f   i t   h a s   f o u n d   a   s h i p  
 / /   ' '   < / s u m m a r y >  
 p u b l i c   c l a s s   A I M e d i u m P l a y e r   {  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   P r i v a t e   e n u m a r a t o r   f o r   A I   s t a t e s .   c u r r e n t l y   t h e r e   a r e   t w o   s t a t e s ,  
         / /   ' '   t h e   A I   c a n   b e   s e a r c h i n g   f o r   a   s h i p ,   o r   i f   i t   h a s   f o u n d   a   s h i p   i t   w i l l  
         / /   ' '   t a r g e t   t h e   s a m e   s h i p  
         / /   ' '   < / s u m m a r y >  
         p r i v a t e   e n u m   A I S t a t e s   {  
                  
                 S e a r c h i n g ,  
                  
                 T a r g e t i n g S h i p ,  
         }  
          
         p r i v a t e   A I S t a t e s   _ C u r r e n t S t a t e   =   A I S t a t e s . S e a r c h i n g ;  
          
         p r i v a t e   S t a c k < L o c a t i o n >   _ T a r g e t s   =   n e w   S t a c k < L o c a t i o n > ( ) ;  
          
         p u b l i c   A I M e d i u m P l a y e r ( B a t t l e S h i p s G a m e   c o n t r o l l e r )   :    
                         b a s e ( c o n t r o l l e r )   {  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   G e n e r a t e C o o r d i n a t e s   s h o u l d   g e n e r a t e   r a n d o m   s h o o t i n g   c o o r d i n a t e s  
         / /   ' '   o n l y   w h e n   i t   h a s   n o t   f o u n d   a   s h i p ,   o r   h a s   d e s t r o y e d   a   s h i p   a n d    
         / /   ' '   n e e d s   n e w   s h o o t i n g   c o o r d i n a t e s  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   g e n e r a t e d   r o w < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " c o l u m n " > t h e   g e n e r a t e d   c o l u m n < / p a r a m >  
         p r o t e c t e d   o v e r r i d e   v o i d   G e n e r a t e C o o r d s ( r e f   i n t   r o w ,   r e f   i n t   c o l u m n )   {  
                 f o r   (  
                 ;   ( ( r o w   <   0 )    
                                         | |   ( ( c o l u m n   <   0 )    
                                         | |   ( ( r o w   > =   E n e m y G r i d . H e i g h t )    
                                         | |   ( ( c o l u m n   > =   E n e m y G r i d . W i d t h )    
                                         | |   ( E n e m y G r i d . I t e m [ r o w ,   c o l u m n ]   ! =   T i l e V i e w . S e a ) ) ) ) ) ;    
                 )   {  
                         s w i t c h   ( _ C u r r e n t S t a t e )   {  
                                 c a s e   A I S t a t e s . S e a r c h i n g :  
                                         t h i s . S e a r c h C o o r d s ( r o w ,   c o l u m n ) ;  
                                         b r e a k ;  
                                 c a s e   A I S t a t e s . T a r g e t i n g S h i p :  
                                         t h i s . T a r g e t C o o r d s ( r o w ,   c o l u m n ) ;  
                                         b r e a k ;  
                                 d e f a u l t :  
                                         t h r o w   n e w   A p p l i c a t i o n E x c e p t i o n ( " A I   h a s   g o n e   i n   a n   i m v a l i d   s t a t e " ) ;  
                                         b r e a k ;  
                         }  
                 }  
                  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   T a r g e t C o o r d s   i s   u s e d   w h e n   a   s h i p   h a s   b e e n   h i t   a n d   i t   w i l l   t r y   a n d   d e s t r o y  
         / /   ' '   t h i s   s h i p  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " r o w " > r o w   g e n e r a t e d   a r o u n d   t h e   h i t   t i l e < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " c o l u m n " > c o l u m n   g e n e r a t e d   a r o u n d   t h e   h i t   t i l e < / p a r a m >  
         p r i v a t e   v o i d   T a r g e t C o o r d s ( r e f   i n t   r o w ,   r e f   i n t   c o l u m n )   {  
                 L o c a t i o n   l   =   _ T a r g e t s . P o p ( ) ;  
                 i f   ( ( _ T a r g e t s . C o u n t   = =   0 ) )   {  
                         _ C u r r e n t S t a t e   =   A I S t a t e s . S e a r c h i n g ;  
                 }  
                  
                 r o w   =   l . R o w ;  
                 c o l u m n   =   l . C o l u m n ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   S e a r c h C o o r d s   w i l l   r a n d o m l y   g e n e r a t e   s h o t s   w i t h i n   t h e   g r i d   a s   l o n g   a s   i t s   n o t   h i t   t h a t   t i l e   a l r e a d y  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   g e n e r a t e d   r o w < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " c o l u m n " > t h e   g e n e r a t e d   c o l u m n < / p a r a m >  
         p r i v a t e   v o i d   S e a r c h C o o r d s ( r e f   i n t   r o w ,   r e f   i n t   c o l u m n )   {  
                 r o w   =   _ R a n d o m . N e x t ( 0 ,   E n e m y G r i d . H e i g h t ) ;  
                 c o l u m n   =   _ R a n d o m . N e x t ( 0 ,   E n e m y G r i d . W i d t h ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   P r o c e s s S h o t   w i l l   b e   c a l l e d   u p p o n   w h e n   a   s h i p   i s   f o u n d .  
         / /   ' '   I t   w i l l   c r e a t e   a   s t a c k   w i t h   t a r g e t s   i t   w i l l   t r y   t o   h i t .   T h e s e   t a r g e t s  
         / /   ' '   w i l l   b e   a r o u n d   t h e   t i l e   t h a t   h a s   b e e n   h i t .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   r o w   i t   n e e d s   t o   p r o c e s s < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   i t   n e e d s   t o   p r o c e s s < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " r e s u l t " > t h e   r e s u l t   o g   t h e   l a s t   s h o t   ( s h o u l d   b e   h i t ) < / p a r a m >  
         p r o t e c t e d   o v e r r i d e   v o i d   P r o c e s s S h o t ( i n t   r o w ,   i n t   c o l ,   A t t a c k R e s u l t   r e s u l t )   {  
                 i f   ( ( r e s u l t . V a l u e   = =   R e s u l t O f A t t a c k . H i t ) )   {  
                         _ C u r r e n t S t a t e   =   A I S t a t e s . T a r g e t i n g S h i p ;  
                         t h i s . A d d T a r g e t ( ( r o w   -   1 ) ,   c o l ) ;  
                         t h i s . A d d T a r g e t ( r o w ,   ( c o l   -   1 ) ) ;  
                         t h i s . A d d T a r g e t ( ( r o w   +   1 ) ,   c o l ) ;  
                         t h i s . A d d T a r g e t ( r o w ,   ( c o l   +   1 ) ) ;  
                 }  
                 e l s e   i f   ( ( r e s u l t . V a l u e   = =   R e s u l t O f A t t a c k . S h o t A l r e a d y ) )   {  
                         t h r o w   n e w   A p p l i c a t i o n E x c e p t i o n ( " E r r o r   i n   A I " ) ;  
                 }  
                  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   A d d T a r g e t   w i l l   a d d   t h e   t a r g e t s   i t   w i l l   s h o o t   o n t o   a   s t a c k  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   r o w   o f   t h e   t a r g e t s   l o c a t i o n < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " c o l u m n " > t h e   c o l u m n   o f   t h e   t a r g e t s   l o c a t i o n < / p a r a m >  
         p r i v a t e   v o i d   A d d T a r g e t ( i n t   r o w ,   i n t   c o l u m n )   {  
                 i f   ( ( ( r o w   > =   0 )    
                                         & &   ( ( c o l u m n   > =   0 )    
                                         & &   ( ( r o w   <   E n e m y G r i d . H e i g h t )    
                                         & &   ( ( c o l u m n   <   E n e m y G r i d . W i d t h )    
                                         & &   ( E n e m y G r i d . I t e m [ r o w ,   c o l u m n ]   = =   T i l e V i e w . S e a ) ) ) ) ) )   {  
                         _ T a r g e t s . P u s h ( n e w   L o c a t i o n ( r o w ,   c o l u m n ) ) ;  
                 }  
                  
         }  
 } 