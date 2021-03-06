/ /   ' '   < s u m m a r y >  
 / /   ' '   A I H a r d P l a y e r   i s   a   t y p e   o f   p l a y e r .   T h i s   A I   w i l l   k n o w   d i r e c t i o n s   o f   s h i p s  
 / /   ' '   w h e n   i t   h a s   f o u n d   2   s h i p   t i l e s   a n d   w i l l   t r y   t o   d e s t r o y   t h a t   s h i p .   I f   t h a t   s h i p  
 / /   ' '   i s   n o t   d e s t r o y e d   i t   w i l l   s h o o t   t h e   o t h e r   w a y .   S h i p   s t i l l   n o t   d e s t r o y e d ,   t h e n  
 / /   ' '   t h e   A I   k n o w s   i t   h a s   h i t   m u l t i p l e   s h i p s .   T h e n   w i l l   t r y   t o   d e s t o y   a l l   a r o u n d   t i l e s  
 / /   ' '   t h a t   h a v e   b e e n   h i t .  
 / /   ' '   < / s u m m a r y >  
 p u b l i c   c l a s s   A I H a r d P l a y e r   {  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   T a r g e t   a l l o w s   t h e   A I   t o   k n o w   m o r e   t h i n g s ,   f o r   e x a m p l e   t h e   s o u r c e   o f   a  
         / /   ' '   s h o t   t a r g e t  
         / /   ' '   < / s u m m a r y >  
         c l a s s   T a r g e t   {  
                  
                 p r i v a t e   L o c a t i o n   _ S h o t A t ;  
                  
                 p r i v a t e   L o c a t i o n   _ S o u r c e ;  
                  
                 / /   ' '   < s u m m a r y >  
                 / /   ' '   T h e   t a r g e t   s h o t   a t  
                 / /   ' '   < / s u m m a r y >  
                 / /   ' '   < v a l u e > T h e   t a r g e t   s h o t   a t < / v a l u e >  
                 / /   ' '   < r e t u r n s > T h e   t a r g e t   s h o t   a t < / r e t u r n s >  
                 p u b l i c   L o c a t i o n   S h o t A t   {  
                         g e t   {  
                                 r e t u r n   _ S h o t A t ;  
                         }  
                 }  
                  
                 p u b l i c   L o c a t i o n   S o u r c e   {  
                         g e t   {  
                                 r e t u r n   _ S o u r c e ;  
                         }  
                 }  
                  
                 i n t e r n a l   T a r g e t ( L o c a t i o n   s h o o t a t ,   L o c a t i o n   s o u r c e )   {  
                         _ S h o t A t   =   s h o o t a t ;  
                         _ S o u r c e   =   s o u r c e ;  
                 }  
                  
                 / /   ' '   < s u m m a r y >  
                 / /   ' '   I f   s o u r c e   s h o t   a n d   s h o o t a t   s h o t   a r e   o n   t h e   s a m e   r o w   t h e n    
                 / /   ' '   g i v e   a   b o o l e a n   t r u e  
                 / /   ' '   < / s u m m a r y >  
                 p u b l i c   b o o l   S a m e R o w   {  
                         g e t   {  
                                 r e t u r n ;  
                         }  
                 }  
                  
                 p u b l i c   b o o l   S a m e C o l u m n   {  
                         g e t   {  
                                 r e t u r n ;  
                         }  
                 }  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   P r i v a t e   e n u m a r a t o r   f o r   A I   s t a t e s .   c u r r e n t l y   t h e r e   a r e   t w o   s t a t e s ,  
         / /   ' '   t h e   A I   c a n   b e   s e a r c h i n g   f o r   a   s h i p ,   o r   i f   i t   h a s   f o u n d   a   s h i p   i t   w i l l  
         / /   ' '   t a r g e t   t h e   s a m e   s h i p  
         / /   ' '   < / s u m m a r y >  
         p r i v a t e   e n u m   A I S t a t e s   {  
                  
                 / /   ' '   < s u m m a r y >  
                 / /   ' '   T h e   A I   i s   s e a r c h i n g   f o r   i t s   n e x t   t a r g e t  
                 / /   ' '   < / s u m m a r y >  
                 S e a r c h i n g ,  
                  
                 / /   ' '   < s u m m a r y >  
                 / /   ' '   T h e   A I   i s   t r y i n g   t o   t a r g e t   a   s h i p  
                 / /   ' '   < / s u m m a r y >  
                 T a r g e t i n g S h i p ,  
                  
                 / /   ' '   < s u m m a r y >  
                 / /   ' '   T h e   A I   i s   l o c k e d   o n t o   a   s h i p  
                 / /   ' '   < / s u m m a r y >  
                 H i t t i n g S h i p ,  
         }  
          
         p r i v a t e   A I S t a t e s   _ C u r r e n t S t a t e   =   A I S t a t e s . S e a r c h i n g ;  
          
         p r i v a t e   S t a c k < T a r g e t >   _ T a r g e t s   =   n e w   S t a c k < T a r g e t > ( ) ;  
          
         p r i v a t e   L i s t < T a r g e t >   _ L a s t H i t   =   n e w   L i s t < T a r g e t > ( ) ;  
          
         p r i v a t e   T a r g e t   _ C u r r e n t T a r g e t ;  
          
         p u b l i c   A I H a r d P l a y e r ( B a t t l e S h i p s G a m e   g a m e )   :    
                         b a s e ( g a m e )   {  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   G e n e r a t e C o o r d s   w i l l   c a l l   u p o n   t h e   r i g h t   m e t h o d s   t o   g e n e r a t e   t h e   a p p r o p r i a t e   s h o o t i n g  
         / /   ' '   c o o r d i n a t e s  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   r o w   t h a t   w i l l   b e   s h o t   a t < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " c o l u m n " > t h e   c o l u m n   t h a t   w i l l   b e   s h o t   a t < / p a r a m >  
         p r o t e c t e d   o v e r r i d e   v o i d   G e n e r a t e C o o r d s ( r e f   i n t   r o w ,   r e f   i n t   c o l u m n )   {  
                 f o r   (  
                 ;   ( ( r o w   <   0 )    
                                         | |   ( ( c o l u m n   <   0 )    
                                         | |   ( ( r o w   > =   E n e m y G r i d . H e i g h t )    
                                         | |   ( ( c o l u m n   > =   E n e m y G r i d . W i d t h )    
                                         | |   ( E n e m y G r i d . I t e m [ r o w ,   c o l u m n ]   ! =   T i l e V i e w . S e a ) ) ) ) ) ;    
                 )   {  
                         _ C u r r e n t T a r g e t   =   n u l l ;  
                         s w i t c h   ( _ C u r r e n t S t a t e )   {  
                                 c a s e   A I S t a t e s . S e a r c h i n g :  
                                         t h i s . S e a r c h C o o r d s ( r o w ,   c o l u m n ) ;  
                                         b r e a k ;  
                                 c a s e   A I S t a t e s . T a r g e t i n g S h i p :  
                                 c a s e   A I S t a t e s . H i t t i n g S h i p :  
                                         t h i s . T a r g e t C o o r d s ( r o w ,   c o l u m n ) ;  
                                         b r e a k ;  
                                 d e f a u l t :  
                                         t h r o w   n e w   A p p l i c a t i o n E x c e p t i o n ( " A I   h a s   g o n e   i n   a n   i n v a l i d   s t a t e " ) ;  
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
                 T a r g e t   t ;  
                 t   =   _ T a r g e t s . P o p ( ) ;  
                 r o w   =   t . S h o t A t . R o w ;  
                 c o l u m n   =   t . S h o t A t . C o l u m n ;  
                 _ C u r r e n t T a r g e t   =   t ;  
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
                 _ C u r r e n t T a r g e t   =   n e w   T a r g e t ( n e w   L o c a t i o n ( r o w ,   c o l u m n ) ,   n u l l ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   P r o c e s s S h o t   i s   a b l e   t o   p r o c e s s   e a c h   s h o t   t h a t   i s   m a d e   a n d   c a l l   t h e   r i g h t   m e t h o d s   b e l o n g i n g  
         / /   ' '   t o   t h a t   s h o t .   F o r   e x a m p l e ,   i f   i t s   a   m i s s   =   d o   n o t h i n g ,   i f   i t ' s   a   h i t   =   p r o c e s s   t h a t   h i t   l o c a t i o n  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   r o w   t h a t   w a s   s h o t   a t < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   t h a t   w a s   s h o t   a t < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " r e s u l t " > t h e   r e s u l t   f r o m   t h a t   h i t < / p a r a m >  
         p r o t e c t e d   o v e r r i d e   v o i d   P r o c e s s S h o t ( i n t   r o w ,   i n t   c o l ,   A t t a c k R e s u l t   r e s u l t )   {  
                 s w i t c h   ( r e s u l t . V a l u e )   {  
                         c a s e   R e s u l t O f A t t a c k . M i s s :  
                                 _ C u r r e n t T a r g e t   =   n u l l ;  
                                 b r e a k ;  
                         c a s e   R e s u l t O f A t t a c k . H i t :  
                                 P r o c e s s H i t ( r o w ,   c o l ) ;  
                                 b r e a k ;  
                         c a s e   R e s u l t O f A t t a c k . D e s t r o y e d :  
                                 t h i s . P r o c e s s D e s t r o y ( r o w ,   c o l ,   r e s u l t . S h i p ) ;  
                                 b r e a k ;  
                         c a s e   R e s u l t O f A t t a c k . S h o t A l r e a d y :  
                                 t h r o w   n e w   A p p l i c a t i o n E x c e p t i o n ( " E r r o r   i n   A I " ) ;  
                                 b r e a k ;  
                 }  
                 i f   ( ( _ T a r g e t s . C o u n t   = =   0 ) )   {  
                         _ C u r r e n t S t a t e   =   A I S t a t e s . S e a r c h i n g ;  
                 }  
                  
                 / /   ' '   < s u m m a r y >  
                 / /   ' '   P r o c e s s D e t r o y   i s   a b l e   t o   p r o c e s s   t h e   d e s t r o y e d   s h i p s   t a r g e t s   a n d   r e m o v e   _ L a s t H i t   t a r g e t s .  
                 / /   ' '   I t   w i l l   a l s o   c a l l   R e m o v e S h o t s A r o u n d   t o   r e m o v e   t a r g e t s   t h a t   i t   w a s   g o i n g   t o   s h o o t   a t  
                 / /   ' '   < / s u m m a r y >  
                 / /   ' '   < p a r a m   n a m e = " r o w " > t h e   r o w   t h a t   w a s   s h o t   a t   a n d   d e s t r o y e d < / p a r a m >  
                 / /   ' '   < p a r a m   n a m e = " c o l " > t h e   r o w   t h a t   w a s   s h o t   a t   a n d   d e s t r o y e d < / p a r a m >  
                 / /   ' '   < p a r a m   n a m e = " s h i p " > t h e   r o w   t h a t   w a s   s h o t   a t   a n d   d e s t r o y e d < / p a r a m >  
         }  
          
         v o i d   P r o c e s s D e s t r o y ( i n t   r o w ,   i n t   c o l ,   S h i p   s h i p )   {  
                 b o o l   f o u n d O r i g i n a l ;  
                 L o c a t i o n   s o u r c e ;  
                 T a r g e t   c u r r e n t ;  
                 c u r r e n t   =   _ C u r r e n t T a r g e t ;  
                 f o u n d O r i g i n a l   =   f a l s e ;  
                 i n t   i ;  
                 f o r   ( i   =   1 ;   ( i    
                                         < =   ( s h i p . H i t s   -   1 ) ) ;   i + + )   {  
                         i f   ( ! f o u n d O r i g i n a l )   {  
                                 s o u r c e   =   c u r r e n t . S o u r c e ;  
                                 / /   S o u r c e   i s   n n o t h i n g   i f   t h e   s h i p   w a s   o r i g i n a l l y   h i t   i n  
                                 / /     t h e   m i d d l e .   T h i s   t h e n   s e a r c h e d   f o r w a r d ,   r a t h e r   t h a n  
                                 / /     b a c k w a r d   t h r o u g h   t h e   l i s t   o f   t a r g e t s  
                                 i f   ( ( s o u r c e   = =   n u l l ) )   {  
                                         s o u r c e   =   c u r r e n t . S h o t A t ;  
                                         f o u n d O r i g i n a l   =   t r u e ;  
                                 }  
                                  
                         }  
                         e l s e   {  
                                 s o u r c e   =   c u r r e n t . S h o t A t ;  
                         }  
                          
                         / /   f i n d   t h e   s o u r c e   i n   _ L a s t H i t  
                         f o r e a c h   ( T a r g e t   t   i n   _ L a s t H i t )   {  
                                 i f   ( ( ( ! f o u n d O r i g i n a l    
                                                         & &   ( t . S h o t A t   = =   s o u r c e ) )    
                                                         | |   ( f o u n d O r i g i n a l    
                                                         & &   ( t . S o u r c e   = =   s o u r c e ) ) ) )   {  
                                         c u r r e n t   =   t ;  
                                         _ L a s t H i t . R e m o v e ( t ) ;  
                                         b r e a k ;  
                                 }  
                                  
                         }  
                          
                         t h i s . R e m o v e S h o t s A r o u n d ( c u r r e n t . S h o t A t ) ;  
                 }  
                  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   R e m o v e S h o t s A r o u n d   w i l l   r e m o v e   t a r g e t s   t h a t   b e l o n g   t o   t h e   d e s t r o y e d   s h i p   b y   c h e c k i n g   i f    
         / /   ' '   t h e   s o u r c e   o f   t h e   t a r g e t s   b e l o n g   t o   t h e   d e s t r o y e d   s h i p .   I f   t h e y   d o n ' t   p u t   t h e m   o n   a   n e w   s t a c k .  
         / /   ' '   T h e n   c l e a r   t h e   t a r g e t s   s t a c k   a n d   m o v e   a l l   t h e   t a r g e t s   t h a t   s t i l l   n e e d   t o   b e   s h o t   a t   b a c k    
         / /   ' '   o n t o   t h e   t a r g e t s   s t a c k  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " t o R e m o v e " > < / p a r a m >  
         p r i v a t e   v o i d   R e m o v e S h o t s A r o u n d ( L o c a t i o n   t o R e m o v e )   {  
                 S t a c k < T a r g e t >   n e w S t a c k   =   n e w   S t a c k < T a r g e t > ( ) ;  
                 / /   c r e a t e   a   n e w   s t a c k  
                 / /   c h e c k   a l l   t a r g e t s   i n   t h e   _ T a r g e t s   s t a c k  
                 f o r e a c h   ( T a r g e t   t   i n   _ T a r g e t s )   {  
                         / /   i f   t h e   s o u r c e   o f   t h e   t a r g e t   d o e s   n o t   b e l o n g   t o   t h e   d e s t r o y e d   s h i p   p u t   t h e m   o n   t h e   n e w S t a c k  
                         i f   ( t . S o u r c e )   {  
                                 I s N o t ;  
                                 t o R e m o v e ;  
                                 n e w S t a c k . P u s h ( t ) ;  
                                 _ T a r g e t s . C l e a r ( ) ;  
                                 / /   c l e a r   t h e   _ T a r g e t s   s t a c k  
                                 / /   f o r   a l l   t h e   t a r g e t s   i n   t h e   n e w S t a c k ,   m o v e   t h e m   b a c k   o n t o   t h e   _ T a r g e t s   s t a c k  
                                 f o r e a c h   ( T a r g e t   t   i n   n e w S t a c k )   {  
                                         _ T a r g e t s . P u s h ( t ) ;  
                                 }  
                                  
                                 / /   i f   t h e   _ T a r g e t s   s t a c k   i s   0   t h e n   c h a n g e   t h e   A I ' s   s t a t e   b a c k   t o   s e a r c h i n g  
                                 i f   ( ( _ T a r g e t s . C o u n t   = =   0 ) )   {  
                                         _ C u r r e n t S t a t e   =   A I S t a t e s . S e a r c h i n g ;  
                                 }  
                                  
                                 / /   ' '   < s u m m a r y >  
                                 / /   ' '   P r o c e s s H i t   g e t s   t h e   l a s t   h i t   l o c a t i o n   c o o r d i n a t e s   a n d   w i l l   a s k   A d d T a r g e t   t o  
                                 / /   ' '   c r e a t e   t a r g e t s   a r o u n d   t h a t   l o c a t i o n   b y   c a l l i n g   t h e   m e t h o d   f o u r   t i m e s   e a c h   t i m e   w i t h  
                                 / /   ' '   a   n e w   l o c a t i o n   a r o u n d   t h e   l a s t   h i t   l o c a t i o n .  
                                 / /   ' '   I t   w i l l   t h e n   s e t   t h e   s t a t e   o f   t h e   A I   a n d   i f   i t ' s   n o t   S e a r c h i n g   o r   t a r g e t i n g S h i p   t h e n    
                                 / /   ' '   s t a r t   R e O r d e r T a r g e t s .  
                                 / /   ' '   < / s u m m a r y >  
                                 / /   ' '   < p a r a m   n a m e = " r o w " > < / p a r a m >  
                                 / /   ' '   < p a r a m   n a m e = " c o l " > < / p a r a m >  
                                 P r o c e s s H i t ( ( ( i n t ) ( r o w ) ) ,   ( ( i n t ) ( c o l ) ) ) ;  
                                 _ L a s t H i t . A d d ( _ C u r r e n t T a r g e t ) ;  
                                 / /   U s e s   _ C u r r e n t T a r g e t   a s   t h e   s o u r c e  
                                 A d d T a r g e t ( ( r o w   -   1 ) ,   c o l ) ;  
                                 A d d T a r g e t ( r o w ,   ( c o l   -   1 ) ) ;  
                                 A d d T a r g e t ( ( r o w   +   1 ) ,   c o l ) ;  
                                 A d d T a r g e t ( r o w ,   ( c o l   +   1 ) ) ;  
                                 i f   ( ( _ C u r r e n t S t a t e   = =   A I S t a t e s . S e a r c h i n g ) )   {  
                                         _ C u r r e n t S t a t e   =   A I S t a t e s . T a r g e t i n g S h i p ;  
                                 }  
                                 e l s e   {  
                                         / /   e i t h e r   t a r g e t t i n g   o r   h i t t i n g . . .   b o t h   a r e   t h e   s a m e   h e r e  
                                         _ C u r r e n t S t a t e   =   A I S t a t e s . H i t t i n g S h i p ;  
                                         R e O r d e r T a r g e t s ( ) ;  
                                 }  
                                  
                         }  
                          
                         / /   ' '   < s u m m a r y >  
                         / /   ' '   R e O r d e r T a r g e t s   w i l l   o p t i m i s e   t h e   t a r g e t i n g   b y   r e - o r d e r i n   t h e   s t a c k   t h a t   t h e   t a r g e t s   a r e   i n .  
                         / /   ' '   B y   p u t t i n g   t h e   m o s t   i m p o r t a n t   t a r g e t s   a t   t h e   t o p   t h e y   a r e   t h e   o n e s   t h a t   w i l l   b e   s h o t   a t   f i r s t .  
                         / /   ' '   < / s u m m a r y >  
                         R e O r d e r T a r g e t s ( ) ;  
                         / /   i f   t h e   s h i p   i s   l y i n g   o n   t h e   s a m e   r o w ,   c a l l   M o v e T o T o p O f S t a c k   t o   o p t i m i s e   o n   t h e   r o w  
                         i f   ( _ C u r r e n t T a r g e t . S a m e R o w )   {  
                                 M o v e T o T o p O f S t a c k ( _ C u r r e n t T a r g e t . S h o t A t . R o w ,   - 1 ) ;  
                         }  
                         e l s e   i f   ( _ C u r r e n t T a r g e t . S a m e C o l u m n )   {  
                                 / /   e l s e   i f   t h e   s h i p   i s   l y i n g   o n   t h e   s a m e   c o l u m n ,   c a l l   M o v e T o T o p O f S t a c k   t o   o p t i m i s e   o n   t h e   c o l u m n  
                                 M o v e T o T o p O f S t a c k ( - 1 ,   _ C u r r e n t T a r g e t . S h o t A t . C o l u m n ) ;  
                         }  
                          
                         / /   ' '   < s u m m a r y >  
                         / /   ' '   M o v e T o T o p O f S t a c k   w i l l   r e - o r d e r   t h e   s t a c k   b y   c h e c k i n   t h e   c o o r d i n a t e s   o f   e a c h   t a r g e t  
                         / /   ' '   I f   t h e y   h a v e   t h e   r i g h t   c o l u m n   o r   r o w   v a l u e s   i t   w i l l   b e   m o v e d   t o   t h e   _ M a t c h   s t a c k   e l s e    
                         / /   ' '   p u t   i t   o n   t h e   _ N o M a t c h   s t a c k .   T h e n   m o v e   a l l   t h e   t a r g e t s   f r o m   t h e   _ N o M a t c h   s t a c k   b a c k   o n   t h e    
                         / /   ' '   _ T a r g e t s   s t a c k ,   t h e s e   w i l l   b e   a t   t h e   b o t t o m   m a k i n g   t h e m   l e s s   i m p o r t a n t .   T h e   m o v e   a l l   t h e  
                         / /   ' '   t a r g e t s   f r o m   t h e   _ M a t c h   s t a c k   o n   t h e   _ T a r g e t s   s t a c k ,   t h e s e   w i l l   b e   o n   t h e   t o p   a n d   w i l l   t h e r e  
                         / /   ' '   f o r   b e   s h o t   a t   f i r s t  
                         / /   ' '   < / s u m m a r y >  
                         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   r o w   o f   t h e   o p t i m i s a t i o n < / p a r a m >  
                         / /   ' '   < p a r a m   n a m e = " c o l u m n " > t h e   c o l u m n   o f   t h e   o p t i m i s a t i o n < / p a r a m >  
                         M o v e T o T o p O f S t a c k ( ( ( i n t ) ( r o w ) ) ,   ( ( i n t ) ( c o l u m n ) ) ) ;  
                         S t a c k < T a r g e t >   _ N o M a t c h   =   n e w   S t a c k < T a r g e t > ( ) ;  
                         S t a c k < T a r g e t >   _ M a t c h   =   n e w   S t a c k < T a r g e t > ( ) ;  
                         T a r g e t   c u r r e n t ;  
                         w h i l e   ( ( _ T a r g e t s . C o u n t   >   0 ) )   {  
                                 c u r r e n t   =   _ T a r g e t s . P o p ( ) ;  
                                 i f   ( ( ( c u r r e n t . S h o t A t . R o w   = =   r o w )    
                                                         | |   ( c u r r e n t . S h o t A t . C o l u m n   = =   c o l u m n ) ) )   {  
                                         _ M a t c h . P u s h ( c u r r e n t ) ;  
                                 }  
                                 e l s e   {  
                                         _ N o M a t c h . P u s h ( c u r r e n t ) ;  
                                 }  
                                  
                         }  
                          
                         f o r e a c h   ( T a r g e t   t   i n   _ N o M a t c h )   {  
                                 _ T a r g e t s . P u s h ( t ) ;  
                         }  
                          
                         f o r e a c h   ( T a r g e t   t   i n   _ M a t c h )   {  
                                 _ T a r g e t s . P u s h ( t ) ;  
                         }  
                          
                         / /   ' '   < s u m m a r y >  
                         / /   ' '   A d d T a r g e t   w i l l   a d d   t h e   t a r g e t s   i t   w i l l   s h o o t   o n t o   a   s t a c k  
                         / /   ' '   < / s u m m a r y >  
                         / /   ' '   < p a r a m   n a m e = " r o w " > t h e   r o w   o f   t h e   t a r g e t s   l o c a t i o n < / p a r a m >  
                         / /   ' '   < p a r a m   n a m e = " c o l u m n " > t h e   c o l u m n   o f   t h e   t a r g e t s   l o c a t i o n < / p a r a m >  
                         A d d T a r g e t ( ( ( i n t ) ( r o w ) ) ,   ( ( i n t ) ( c o l u m n ) ) ) ;  
                         i f   ( ( ( r o w   > =   0 )    
                                                 & &   ( ( c o l u m n   > =   0 )    
                                                 & &   ( ( r o w   <   E n e m y G r i d . H e i g h t )    
                                                 & &   ( ( c o l u m n   <   E n e m y G r i d . W i d t h )    
                                                 & &   ( E n e m y G r i d . I t e m [ r o w ,   c o l u m n ]   = =   T i l e V i e w . S e a ) ) ) ) ) )   {  
                                 _ T a r g e t s . P u s h ( n e w   T a r g e t ( n e w   L o c a t i o n ( r o w ,   c o l u m n ) ,   _ C u r r e n t T a r g e t . S h o t A t ) ) ;  
                         }  
                          
                 }  
                  
         }  
 } 