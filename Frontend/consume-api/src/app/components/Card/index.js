import styles from './card.module.css';


export default async function Card() {
	process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';

	const cards = await fetch('https://localhost:7061/api/Compasses').then(res => res.json());
	cards.forEach(card=>console.log(card));
	console.log(cards[1]);
	return (
		<div className={styles.container}>
			{cards?.map((card) => (
				<div key={card.id} className={styles.card}>
					<img src={card.compass_URL} />
					<div className={styles.card_title}>
						<p>{card.name}</p>
					</div>
				</div>
			))}
		</div>
	)
}
