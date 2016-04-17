<?php include "templates/include/header.php" ?>

    <h1 style="width: 75%;"><?php echo htmlspecialchars( $results['article']->title )?></h1>
    <div style="width: 75%; font-style: italic;"><?php echo htmlspecialchars( $results['article']->summary )?></div>
    <div style="width: 75%;"><?php echo $results['article']->content?></div>
    <p class="pubDate">Published on <?php echo date('j F Y', $results['article']->publication_Date)?>
        <?php if ( $results['category'] ) { ?>
            in <a href="folder?action=archive&amp;categoryId=<?php echo $results['category']->id?>">
                <?php echo htmlspecialchars( $results['category']->name ) ?></a>
        <?php } ?>
    </p>

    <p><a href="folder">Return to Homepage</a></p>

<?php include "templates/include/footer.php" ?>