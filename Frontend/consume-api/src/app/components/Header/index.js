import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<img src="/logo.png" alt="logo" />
			<ul>
				<li>
					<Link href="/RotaUm">Destinos</Link>
				</li>
				<li>
					<Link href="/RotaDois">Link 2</Link>
				</li>
				<li>
					<Link href="/RotaTres">Link 3</Link>
				</li>
			</ul>
		</header>
	)
}