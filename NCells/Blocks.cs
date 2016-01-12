﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCells {
	class Blocks {
		private Block[] blocks;
		public Blocks(int convert) {
			Block.Convert = convert;
			blocks = new Block[] {	new LBlockU(),
									new LBlockR(),
									new LBlockD(),
									new LBlockL(),
									new TurnLBlockU(),
									new TurnLBlockR(),
									new TurnLBlockD(),
									new TurnLBlockL(),
									new SBlockH(),
									new SBlockV(),
									new TurnSBlockH(),
									new TurnSBlockV(),
									new OBlock(),
									new TBlockU(),
									new TBlockR(),
									new TBlockD(),
									new TBlockL(),
									new IBlockV(),
									new IBlockH()};
		}

		public Block[] AllBlocks() {
			return blocks;
		}
	}
}
